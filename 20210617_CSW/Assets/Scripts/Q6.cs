using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q6 : MonoBehaviour
{
    public GameObject c1, c2, c3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * 2.0f * Time.deltaTime);
        if(gameObject.transform.position.x > 0.5f)
        {
            c1.SetActive(true);
        }
        if(gameObject.transform.position.x > 1.5f)
        {
            c2.SetActive(true);
        }
        if(gameObject.transform.position.x > 3.5f)
        {
            c3.SetActive(true);
        }
    }
}
