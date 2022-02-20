using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //object references
    [SerializeField] CharacterController controller;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;

    //variables you can change in the inspector
    [SerializeField] float speed;
    [SerializeField] float gravity;
    [SerializeField] float jumpHeight;
    [SerializeField] float friction;

    //Velocity variables
    Vector3 velocity;
    float xv;
    float zv;

    //variables
    bool isGrounded;
    float groundDistance = 0.3f;
    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //makes an invisible sphere which checks if anything in the ground mask is in it
        
        //if (isGrounded == true && velocity.y < 0)
        //{
        //    velocity.y = -3f;
        //}

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); // to reach the height of h     formula  is v = sqrt(h * -2 * gravity) 
        }

        float x = Input.GetAxisRaw("Horizontal"); //gets inputs
        float z = Input.GetAxisRaw("Vertical");

        xv = (xv + x) * friction; //calculates smooth movement
        zv = (zv + z) * friction;

        Vector3 move = transform.right * xv + transform.forward * zv; //applys the inputs 
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;  //simulating gravity
        controller.Move(velocity * Time.deltaTime); //moves
    }
}
