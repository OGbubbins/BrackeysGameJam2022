using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float turnspeed;
    public float movespeed;
    
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.rotation = transform.rotation * Quaternion.Euler(0f, Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime, 0f);
        
    }
}
