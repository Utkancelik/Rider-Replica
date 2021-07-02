using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 newPos = player.position + offset;
        newPos.z = transform.position.z;

        transform.position = newPos;
    }
}
