using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private void FixedUpdate()
    {
        float curRot = transform.localRotation.eulerAngles.z;
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, curRot + rotationSpeed);
    }
}
