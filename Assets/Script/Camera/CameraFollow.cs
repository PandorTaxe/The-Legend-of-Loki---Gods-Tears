using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private bool _cameraIsFollowing;

    public void UpdateCameraPosition(Vector3 targetPos)
    {
        if (targetPos.x != 0)
        {
            transform.position += targetPos * 35.5f;
        }
        else
        {
            transform.position += targetPos * 20 ;
        }
    }
}