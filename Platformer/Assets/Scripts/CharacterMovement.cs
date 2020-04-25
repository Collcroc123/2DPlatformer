using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
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

    void Update ()
    {
        MoveCharacter(controller);
    }
    
    void MoveCharacter(CharacterController cc)
    {
        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        positionDirection.y -= gravity * Time.deltaTime;
        cc.Move(positionDirection * Time.deltaTime);

        if (startJumping == true)
        {
            if (cc.isGrounded)
            {
                positionDirection.y = jumpForce.value;
                jumpSound.Play(0);
                animate.SetTrigger("Jump");
            }
            return;
        }

        if (Input.GetButtonDown("Jump"))
        {
            startJumping = true;
            animate.SetTrigger("Jump");
            Debug.Log("Pressing Space!");
        }
    }
}
