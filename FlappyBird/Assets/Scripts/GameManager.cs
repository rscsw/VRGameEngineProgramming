using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float waitingTime;
    public bool ready;
    public GameObject cactus;
    public GameObject bird;
    public bool end;
    public AudioClip deathSound;
    public AudioClip goalSound;
    public Text socoreText;
    public GameObject readyimg1, readyimg2;
    public GameObject gameOverImg;
    public GameObject finalWindow;
    public GameObject newImg;
    public TextMesh finalScoreText;
    public TextMesh bestScoreText;

    private AudioSource audioSource;
    private int score;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        waitingTime = 1.5f;
        ready = true;
        end = false;
        score = 0;
        // PlayerPrefs.SetInt("BestScore", 0);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && ready == true)
        {
            ready = false;
            InvokeRepeating("MakeCactus", 1f, waitingTime);
            iTween.FadeTo(readyimg1, iTween.Hash("alpha", 0, "time", 0.5f));
            iTween.FadeTo(readyimg2, iTween.Hash("alpha", 0, "time", 0.5f));
            bird.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void MakeCactus()
    {
        Instantiate(cactus);
    }

    public void GameOver()
    {
        end = true;
        CancelInvoke("MakeCactus");
        // AudioSource.PlayClipAtPoint(deathSound, transform.position);
        iTween.ShakePosition(Camera.main.gameObject, iTween.Hash("x", 0.2, "y", 0.2, "time", 0.5f));
        audioSource.clip = deathSound;
        audioSource.Play();

        iTween.FadeTo(gameOverImg, iTween.Hash("alpha", 255, "delay", 1f, "time", 0.5f));
        iTween.MoveTo(finalWindow, iTween.Hash("y", 1, "delay", 1.3f, "time", 0.5f));

        if(score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
        {
            newImg.SetActive(false);
        }
        finalScoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void GetScore()
    {
        // AudioSource.PlayClipAtPoint(goalSound, transform.position);
        if(end != true)
        {
            audioSource.clip = goalSound;
            audioSource.Play();
            score += 1;
            socoreText.text = score.ToString();
        }
    }
}
