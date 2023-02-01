using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q13 : MonoBehaviour
{
    int score;
    public Text text;

    void Start()
    {
        
    }

    void Update()
    {
        text.text = "Score : " + score.ToString();
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            score += 10;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            score -= 10;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            score = 0;
        }
    }
}
