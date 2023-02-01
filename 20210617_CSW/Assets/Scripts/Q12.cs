using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q12 : MonoBehaviour
{
    public GameObject a, b;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AB()
    {
        b.SetActive(true);
        a.SetActive(false);
    }

    public void BB()
    {
        a.SetActive(true);
        b.SetActive(false);
    }
}
