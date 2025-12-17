using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class LookAround : MonoBehaviour
{
    public float rotationSpeed = 0.15f;

    void OnEnable()
    {
        LeanTouch.OnFingerUpdate += OnFingerUpdate;
    }

    void OnDisable()
    {
        LeanTouch.OnFingerUpdate -= OnFingerUpdate;
    }

    void OnFingerUpdate(LeanFinger finger)
    {
        if (finger.IsOverGui) return;

        float yaw = finger.ScaledDelta.x * rotationSpeed;
        transform.Rotate(0f, yaw, 0f, Space.Self);
    }
}

