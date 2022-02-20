using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed;
    Vector3 velocity;
    float gravity = -9.8f;
    float jumpHeight = 2f;
    bool isGrounded;

    [SerializeField] Transform groundCheck;
    float groundDistance = 0.4f;
    [SerializeField] LayerMask groundMask;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //makes an invisible sphere which checks if anything in the ground mask is in it
        if (isGrounded == true && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); // to reach the height of h     formula  is v = sqrt(h * -2 * gravity) 
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;  //simulating gravity
        controller.Move(velocity * Time.deltaTime);
    }
}
