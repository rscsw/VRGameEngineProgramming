using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q19 : MonoBehaviour
{
    public GameObject text;
    bool isShow = true;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isShow)
        {
            text.SetActive(false);
            isShow = false;
        }
        if(Input.GetKeyDown(KeyCode.Space) && !isShow)
        {
            text.SetActive(true);
            isShow = true;
        }
    }
}
