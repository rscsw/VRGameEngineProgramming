using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum GameState
{
    Ready,
    Play, 
    End
}

public class GameManager : MonoBehaviour
{
    public GameState gs;
    public AudioClip readySound, goSound;
    public float limitTime;
    public TextMeshPro timeText;
    public int score;
    public TextMeshPro scoreText;
    public GameObject black;
    public TextMeshPro highScoreText;
    public TextMeshPro endScoreText;
    public GameObject finalWindow;

    AudioSource audioSource;

    void GameOver()
    {
        gs = GameState.End;
        iTween.FadeTo(black, iTween.Hash("alpha", 180, "delay", 0.1f, "time", 0.5f));

        iTween.MoveTo(finalWindow, iTween.Hash("y", 0, "delay", 0.5f, "time", 0.5f));

        if (score > PlayerPrefs.GetInt("BestScore"))
            PlayerPrefs.SetInt("BestScore", score);

        endScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = readySound;
        audioSource.Play();
        timeText.text = limitTime.ToString("N2");
        scoreText.text = "0";
    }

    public void Go()
    {
        gs = GameState.Play;
        audioSource.clip = goSound;
        audioSource.Play();
    }

    void Update()
    {
        if(gs == GameState.Play)
        {
            limitTime -= Time.deltaTime;
            if (limitTime <= 0)
            {
                limitTime = 0;
                GameOver();
            }
            timeText.text = limitTime.ToString("N2");
            scoreText.text = score.ToString();
        }

    }
}
