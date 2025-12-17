using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMove : MonoBehaviour
{
    public float moveSpeed = 2f;      // Movement speed
    public float boundaryRadius = 5f; // Max distance from start position

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Save starting point
    }

    void Update()
    {
        Vector3 moveDir = Vector3.zero;

        // EDITOR: W/S keys or Up/Down arrow
        float vertical = Input.GetAxis("Vertical"); 
        moveDir += transform.forward * vertical;

        // MOBILE: optional two-finger swipe forward/backward
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector2 swipe = touch1.deltaPosition + touch2.deltaPosition;
            moveDir += transform.forward * (swipe.y * 0.01f);
        }

        // Calculate new position
        Vector3 newPos = transform.position + moveDir * moveSpeed * Time.deltaTime;

        // Keep inside room boundary
        if (Vector3.Distance(startPos, newPos) <= boundaryRadius)
            transform.position = newPos;
    }
}