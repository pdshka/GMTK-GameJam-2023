using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbMobileController : MonoBehaviour
{
    private Rigidbody rigidbody;

    [Header("Sensitivity settings")]
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;

    [Header("BulbMobile settings")]
    [SerializeField] private float speed = 1.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.forward * speed;
    }

    public void ResetRotation()
    {
        yaw = 0.0f;
        pitch = 0.0f;
    }
}
