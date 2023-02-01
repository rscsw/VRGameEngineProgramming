using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q20 : MonoBehaviour
{
    public GameObject text;

    void Start()
    {
        
    }

    void Update()
    {
        if(gameObject.transform.position.y < -7)
        {
            text.SetActive(true);
        }
    }
}
