using System;
using Player;
using UnityEngine;
using UnityEngine.Events;

public class SwapArea : MonoBehaviour
{
    public int  AreaToSwap = 0; //0: vertical ; 1: horizontal
    [SerializeField] private CameraFollow _cameraFollow;
    private Vector3 _playerPosition = Vector3.zero;

    [SerializeField] private int direction;

    void OnTriggerEnter2D(Collider2D _other)
    {
    
        Vector2 _direction = CalculDirection(_other.gameObject.transform.position);
        _other.transform.position += (Vector3)_direction * 2;
        _cameraFollow.UpdateCameraPosition(_direction);
    }

    private Vector2 CalculDirection(Vector2 _playerTransform)
    {
        Vector2 _playerPos = (Vector2)transform.position - _playerTransform;
        Vector2 _direction = Vector2.zero;

        switch (direction)
        {
            case 0 :
                _direction.x = Mathf.Sign(_playerPos.x);
                break;
            case 1 :
                _direction.y = Mathf.Sign(_playerPos.y);
                break;
        }

        return _direction;
    }
}
