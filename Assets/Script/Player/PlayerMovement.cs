using System;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private PlayerController _playerController;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _playerController = GetComponentInParent<PlayerController>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rigidbody2D.linearVelocity = _playerController._moveInput * _speed;
        }
    }
}