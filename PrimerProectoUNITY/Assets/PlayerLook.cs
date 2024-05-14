using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private float XMouse;
    private float YMouse;
    private float XRotation;
    public Transform PlayerBody;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        XMouse = Input.GetAxis("Mouse X");
        YMouse = Input.GetAxis("Mouse Y");
        XRotation -= YMouse;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * XMouse);


    }
}
