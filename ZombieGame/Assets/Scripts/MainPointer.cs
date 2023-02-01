using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainPointer : MonoBehaviour
{
    public Image loadingImg;
    public AudioClip gunSound;
    public AudioClip reloadSound;
    public int maxBullet;
    public TextMeshProUGUI bulletText;
    public int score;
    public TextMeshProUGUI scoreText;

    int nowBullet;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nowBullet = maxBullet;
        bulletText.text = nowBullet + " / " + maxBullet;
        scoreText.text = score.ToString();
    }

    IEnumerator ReloadGun()
    {
        bulletText.text = "Reloading...";
        yield return new WaitForSeconds(1.2f);
        audioSource.PlayOneShot(reloadSound);
        nowBullet = maxBullet;
        bulletText.text = nowBullet + " / " + maxBullet;
    }

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 500f))
        {
            if(hit.collider.CompareTag("Zombie") && nowBullet > 0)
            {
                loadingImg.fillAmount += 1.0f / 2 * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    nowBullet -= 1;
                    score += Random.Range(500, 1000);
                    scoreText.text = score.ToString();
                    bulletText.text = nowBullet + " / " + maxBullet;
                    audioSource.PlayOneShot(gunSound);

                    if(nowBullet == 0) StartCoroutine(ReloadGun());

                    hit.collider.gameObject.GetComponent<Animator>().SetTrigger("Die");
                    hit.collider.gameObject.GetComponent<ZombieMove>().speed = 0;
                    hit.collider.gameObject.GetComponent<CapsuleCollider>().radius = 0;
                    Destroy(hit.collider.gameObject, 2.0f);
                    loadingImg.fillAmount = 0;
                }
            }
            else
            {
                loadingImg.fillAmount = 0;
            }
        }
        else
        {
            loadingImg.fillAmount = 0;
        }
    }
}
