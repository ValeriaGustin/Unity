using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float xMove;
    private float yMove;
    public CharacterController characterController;
    public float SpeedMove = 10f;

    public float Gravity = -9.81f;
    public Transform GroundCheck;
    public float GroundDistance = 0.3f;
    public LayerMask layerMask;
    public bool isGround;
    Vector3 velocity;
    public float Jump = 10f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGround = Physics.CheckSphere(GroundCheck.position, GroundDistance, layerMask);

        if (velocity.y < 0 && isGround)
        {
            velocity.y = -2f;
        }

        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * xMove + transform.forward * yMove;
        characterController.Move(Move * SpeedMove * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGround)
        {
            velocity.y = Mathf.Sqrt(Jump * -2 * Gravity);
            isGround = false;
        }

        velocity.y += Gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
