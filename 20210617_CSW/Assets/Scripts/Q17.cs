using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q17 : MonoBehaviour
{
    public GameObject box;
    Rigidbody rb;
    bool isDrop = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(isDrop)
        {
            rb.useGravity = true;
        }
    }

    public void BC()
    {
        isDrop = true;
    }
}
