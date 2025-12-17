using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileLook : MonoBehaviour
{
    public float sensitivity = 0.2f;
    public Transform pivot;   // CameraPivot

    float rotationX = 0f;

    void Start()
    {
        if (pivot == null)
            pivot = transform.parent;
    }

    void Update()
    {
        float deltaX = 0f;
        float deltaY = 0f;

        // TOUCH INPUT (Mobile)
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                deltaX = touch.deltaPosition.x;
                deltaY = touch.deltaPosition.y;
            }
        }

        // MOUSE INPUT (Editor)
        if (Input.touchCount == 0 && Input.GetMouseButton(0))
        {
            deltaX = Input.GetAxis("Mouse X") * 10f;
            deltaY = Input.GetAxis("Mouse Y") * 10f;
        }

        if (deltaX != 0f || deltaY != 0f)
        {
            rotationX -= deltaY * sensitivity;
            rotationX = Mathf.Clamp(rotationX, -80f, 80f);

            // Look up/down (camera)
            transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

            // Look left/right (pivot)
            pivot.Rotate(Vector3.up * deltaX * sensitivity);
        }
    }
}
