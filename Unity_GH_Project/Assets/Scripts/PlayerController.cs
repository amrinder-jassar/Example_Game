using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //############################################
    //ROTATE PLAYER TO FACE MOUSE POSITION ALWAYS

    private CharacterController controller;
    Vector3 moveInput;
    public float moveSpeed;
    float gravity = 0.01f;
    Vector3 mousePos;
    Vector3 direction;
    Vector3 playerPos;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        mousePos = Input.mousePosition; // CAPTURES MOUSE POSITION
        // Unity return Screen coordinate system for  mouse and player position is in world coordinate.

        // before interaction between mouse and player pos they need to be at same coordinate system.
        playerPos = Camera.main.WorldToScreenPoint(transform.position); // converts player position to screen.
        direction = mousePos - playerPos;//CALCULATE DIRECTION

        // Math function return rotation in radian for player to look at mouse and then convert radian in degree
        float rotAngle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-rotAngle, Vector3.up);
    }

    private void FixedUpdate()
    {
        moveInput.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveInput.z = Input.GetAxis("Vertical") * moveSpeed;
        if (!controller.isGrounded)
        {
            moveInput.y = moveInput.y - gravity;
        }

        this.controller.Move(moveInput);
    }
}
