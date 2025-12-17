using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveForward : MonoBehaviour
{
    public float speed = 1.5f;

    public void MoveForward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}