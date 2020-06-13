using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float _rotationSpeed;
    private float gravity = -9.81f;
    [SerializeField]
    private float jumpHeight;
    Vector3 velovity;
    [SerializeField]
    private Transform groundCheck;
    private float groundDistance = 0.4f;
    [SerializeField]
    private LayerMask groundMask;
    bool isGrounded;
    Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        animation = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velovity.y < 0)
        {
            velovity.y = -2f;
        }

        WalkForward();
        WalkBack();
        RotateRight();
        RotateLeft();
        Jump();

        velovity.y += gravity * Time.deltaTime;
        controller.Move(velovity * Time.deltaTime);
    }

    void WalkForward()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = transform.forward * Input.GetAxis("Vertical");
            controller.Move(direction * speed * Time.deltaTime);
            //animation.Stop("StandingFree");
            animation.Play("walk");
        }
        else
        {
            animation.Stop("walk");
        }
    }
    void WalkBack()
    {
       
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 direction = transform.forward * Input.GetAxis("Vertical");
            controller.Move(direction * speed * Time.deltaTime);
            //animation.Stop("StandingFree");
            animation.Play("walking_back");
        }
        else
        {
            animation.Stop("walking_back");
        }
    }
    void RotateRight()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
            animation.Play("Moving_right");
        }
        else
        {
            animation.Stop("Moving_right");
        }
    }
    void RotateLeft()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
            animation.Play("Moving_left");
        }
        else
        {
            animation.Stop("Moving_left");
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velovity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

    }
}
