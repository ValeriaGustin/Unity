using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;
    public float playerSpeed;
    public float vRotacion = 100f;
    public Vector3 pos = new Vector3(0f, 0.051f, -10f);

    public float gravity = 9.8f;
    private Vector3 movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    //GetKey--GetAxis--GetButtonDown(para presionar unic vez)
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.left * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down * vRotacion * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * vRotacion * Time.deltaTime);

        //rotateUp = Input.GetKey(KeyCode.UpArrow);
        //rotateDown = Input.GetKey(KeyCode.DownArrow);
        //rotateRight = Input.GetKey(KeyCode.RightArrow);
        //rotateLeft = Input.GetKey(KeyCode.LeftArrow);
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove);
        Vector3 moveVelocity = moveDirection.normalized * playerSpeed * Time.deltaTime; // Calcula la velocidad del movimiento

        setGravity();
        player.Move(moveVelocity);
    }

    void setGravity()
    {
        movePlayer.y = -gravity * Time.deltaTime;
    }
}