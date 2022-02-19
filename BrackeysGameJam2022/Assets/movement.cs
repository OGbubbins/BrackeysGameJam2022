using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public CharacterController Controller;

    public float turnspeed;
    public float movespeed;
    float turn;
    public float turnfriction;
    
    void Update()
    {
        turn = (turn + Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime) * turnfriction;
        transform.rotation = transform.rotation * Quaternion.Euler(0f, turn, 0f);
        Controller.Move(transform.forward * Input.GetAxis("Vertical") * movespeed * Time.deltaTime);
        FindObjectOfType<follow>().Movecamera();
        Debug.Log(Time.deltaTime);
    }
}
