using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q21_1 : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        cube.transform.position = new Vector3(3, 0, 0);
    }
}
