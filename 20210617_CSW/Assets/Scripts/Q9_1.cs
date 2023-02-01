using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q9_1 : MonoBehaviour
{
    Rigidbody rb;
    public Q9 sc;
    bool isFall;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(transform.position.y < -8 && !isFall)
        {
            sc.score += 10;
            isFall = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            rb.useGravity = true;
        }
    }
}
