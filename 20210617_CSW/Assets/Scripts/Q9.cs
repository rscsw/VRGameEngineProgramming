using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q9 : MonoBehaviour
{
    public Text scoreTxt;
    public int score;

    void Start()
    {
        
    }

    void Update()
    {
        scoreTxt.text = "Score : " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            score += 1;
        }
    }    
}
