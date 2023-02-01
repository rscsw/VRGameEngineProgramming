using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q18 : MonoBehaviour
{
    bool isMove = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(isMove)
        {
            gameObject.transform.Translate(Vector3.right * 3f * Time.deltaTime);
        }
        if(!isMove)
        {
            gameObject.transform.Translate(Vector3.left * 3f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            isMove = false;
        }
        if(other.CompareTag("Player"))
        {
            isMove = true;
        }
    }
}
