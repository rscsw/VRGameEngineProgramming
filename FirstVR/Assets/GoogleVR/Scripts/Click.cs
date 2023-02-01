using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Image loadingImg;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 500f))
        {
            if(hit.collider.CompareTag("Box"))
            {
                loadingImg.fillAmount += 1.0f / 2 * Time.deltaTime;
                if(loadingImg.fillAmount == 1)
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        } 
        else
        {
            loadingImg.fillAmount = 0;
        }
    }
}
