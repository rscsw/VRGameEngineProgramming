using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q23 : MonoBehaviour
{
    public Text text;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Count : " + count.ToString();

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            count += 1;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            count -= 1;
        }  
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            count += 10;
        }  
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            count -= 10;
        }  
    }
}
