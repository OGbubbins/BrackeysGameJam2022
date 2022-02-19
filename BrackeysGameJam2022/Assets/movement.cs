using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public CharacterController Controller;

    public float turnspeed;
    public float movespeed;
    
    void Update()
    {
        
        transform.rotation = transform.rotation * Quaternion.Euler(0f, Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime, 0f);
        Controller.Move(transform.forward * Input.GetAxis("Vertical") * movespeed * Time.deltaTime);
        


    }
}
