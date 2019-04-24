using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    private const float Y_ANGLE_MIN = -20.0f;
    private const float Y_ANGLE_MAX = 70.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    public float distance = 10.0f;
    public float currentX = 0.0f;
    public float currentY = 0.0f;
    public float sensitivityX = 10.0f;
    public float sensitivityY = 10.0f;


    private void Start ()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY += Input.GetAxis("Mouse Y") * sensitivityY;

        //Applies clamp parameters to camera to avoid full Y rotation
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}

