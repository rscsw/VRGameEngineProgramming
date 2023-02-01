using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Image hpImg;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Zombie")) hpImg.fillAmount -= 1.0f / 5.0f;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(hpImg.fillAmount == 0) Time.timeScale -= 1.0f * Time.deltaTime;
    }
}
