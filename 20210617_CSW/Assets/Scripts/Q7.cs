using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q7 : MonoBehaviour
{
    public GameObject plane;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            plane.SetActive(true);
        }
    }
}
