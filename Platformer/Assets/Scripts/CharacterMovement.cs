using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    //public CharacterController controller2;
    //public CharacterController controller3;
    private Vector3 positionDirection = Vector3.zero;
    private float gravity = 15f;
    public float speed = 10f;
    public FloatData jumpForce;
    public bool startJumping = false;
    public AudioSource jumpSound;
    public Animator animate;

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
            animate.SetTrigger("Jump");
        }

        if (startJumping == true)
        {
            if (controller.isGrounded) //|| controller2.isGrounded || controller3.isGrounded
            {
                positionDirection.y = jumpForce.value;
                jumpSound.Play(0);
                animate.SetTrigger("Jump");
            }
        }
    }
}
