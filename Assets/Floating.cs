using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    
    GameObject Disc;
    float speed = 0f;
    float max = 0f;
    float min = 0f;


    void Start()
    {
       
    }

    
    void Update()
    {
        Disc.transform.position = new Vector3(0, Mathf.Sin(max * speed), 0);
    }
}
