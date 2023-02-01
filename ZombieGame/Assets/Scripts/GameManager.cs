using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject zombie;

    void Start()
    {
        InvokeRepeating("CreateZombie", 1.0f, 2.0f);
    }

    void Update()
    {
        
    }

    void CreateZombie()
    {
        Vector3 positionValue = new Vector3(Random.Range(18.0f, -18.0f), 0.5f, Random.Range(15.0f, 25.0f));
        Instantiate(zombie, positionValue, Quaternion.identity);
    }
}
