using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotationSpeed;
    [SerializeField]
    private float _jumpHeight;
    [SerializeField]
    private Transform _groundCheck;
    [SerializeField]
    private LayerMask _groundMask;

    private float _gravity = -9.81f;
    private float _groundDistance = 0.4f;
    private Vector3 _velovity;
    private bool _isGrounded;

    private CharacterController _controller;
    private Animation _animation;

    // Start is called before the first frame update
    void Start()
    {
        _controller = this.GetComponent<CharacterController>();
        _animation = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        // Make sure that the player will stay on ground
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && _velovity.y < 0)
        {
            _velovity.y = -2f;
        }

        _velovity.y += _gravity * Time.deltaTime;
        _controller.Move(_velovity * Time.deltaTime);

        // Player options of movement - also activates the movement animations
        WalkForward();
        WalkBack();
        RotateRight();
        RotateLeft();
        Jump();
    }

    void WalkForward()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = transform.forward * Input.GetAxis("Vertical");
            _controller.Move(direction * _speed * Time.deltaTime);
            //animation.Stop("StandingFree");
            _animation.Play("walk");
        }
        else
        {
            _animation.Stop("walk");
        }
    }
    void WalkBack()
    {
       
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 direction = transform.forward * Input.GetAxis("Vertical");
            _controller.Move(direction * _speed * Time.deltaTime);
            //animation.Stop("StandingFree");
            _animation.Play("walking_back");
        }
        else
        {
            _animation.Stop("walking_back");
        }
    }
    void RotateRight()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
            _animation.Play("Moving_right");
        }
        else
        {
            _animation.Stop("Moving_right");
        }
    }
    void RotateLeft()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
            _animation.Play("Moving_left");
        }
        else
        {
            _animation.Stop("Moving_left");
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velovity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }

    }
}
