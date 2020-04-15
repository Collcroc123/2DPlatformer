using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection = Vector3.zero;
    private float gravity = 9.8f;
    public float speed = 10f;
    public float jumpForce = 10f;
    private int maxJump = 1;
    private bool isJumping = false;
    private bool startJumping = false;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        positionDirection.y -= gravity * Time.deltaTime;
        controller.Move(positionDirection * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            startJumping = true;
        }

        if (startJumping == true)
        {
            if (controller.isGrounded)
            {
                positionDirection.y = jumpForce;
            }
        }

        //Running
        /*
        if (Input.GetButton("Run"))
        {
            speed = 15f;
        }
        else
        {
            speed = 10f;
        }
        */
    }
}
