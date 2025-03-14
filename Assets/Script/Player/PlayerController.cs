using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public Vector2 _moveInput;
        
        public void Move(InputAction.CallbackContext context)
        {
            _moveInput = context.ReadValue<Vector2>();
        }
    } 
}