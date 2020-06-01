using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    private float speed;
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

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velovity.y < 0)
        {
            velovity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * x + transform.forward * z;
        controller.Move(direction * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velovity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velovity.y += gravity * Time.deltaTime;
        controller.Move(velovity * Time.deltaTime);
    }
}
