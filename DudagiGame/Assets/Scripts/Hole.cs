using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    Animator ani;
    bool touchPossible = false;
    AudioSource audioSourse;
    bool boom;

    public AudioClip openSound;
    public AudioClip catchSound;
    public AudioClip boomSound;
    public GameManager gm;

    void Start()
    {
        ani = GetComponent<Animator>();
        audioSourse = GetComponent<AudioSource>();
    }

    public void Open()
    {
        touchPossible = true;
        audioSourse.clip = openSound;
        audioSourse.Play();
    }

    public void Close()
    {
        touchPossible = false;
    }

    private void OnMouseDown()
    {
        if(touchPossible)
        {
            touchPossible = false;
            ani.SetTrigger("isTouch");
            if(boom)
            {
                audioSourse.clip = boomSound;
                audioSourse.Play();
                gm.score -= 500;

                if(gm.gs == GameState.Ready)
                {
                    gm.Go();
                }
            }
            else
            {
                audioSourse.clip = catchSound;
                audioSourse.Play();
                gm.score += 100;
            }
        }
    }

    public IEnumerator End()
    {
        yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));
        float randomTime = Random.Range(1.0f, 10.0f);

        if(gm.gs != GameState.End)
        {
            if (randomTime >= 5.0f)
            {
                boom = false;
                ani.SetTrigger("A_Open");
            }
            else
            {
                boom = true;
                ani.SetTrigger("B_Open");
            }
        }
    }

    void Update()
    {
        
    }
}
