using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q5 : MonoBehaviour
{
    public GameObject cube;
    bool isMove;
    bool isPlay;

    void Start()
    {
        isMove = true;
        isPlay = false;
    }

    void Update()
    {
        if(isPlay)
        {
            if(!isMove)
            {
                cube.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
                isMove = true;
            }
            if(isMove)
            {
                cube.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
                isMove = true;
            }
        }
    }

    public void CubeMove()
    {
        isPlay = true;

        if(!isMove)
        {
            isMove = true;
        }
        
        if(isMove)
        {
            isMove = false;
        }
    }
}
