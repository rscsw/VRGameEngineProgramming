using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMove : MonoBehaviour
{
    public float cactusSpeed;


    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * cactusSpeed * Time.deltaTime);
        if(transform.position.x < -6f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnEnable()
    {
        transform.position = new Vector3(6f, Random.Range(-1, 1.5f), 0);
    }
}
