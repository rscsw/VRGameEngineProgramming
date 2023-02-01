using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q8 : MonoBehaviour
{
    public Text scoreTxt;
    float score;

    void Start()
    {
        
    }

    void Update()
    {
        score += Time.deltaTime;
        scoreTxt.text = "Score : " + score.ToString("N0");
    }

    public void Reset()
    {
        score = 0;
    }
}
