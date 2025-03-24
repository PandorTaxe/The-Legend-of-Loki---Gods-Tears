using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PauseMenuController : MonoBehaviour
{
    public GameObject _pauseMenuCanvas;

    void Start()
    {
        _pauseMenuCanvas.SetActive(false);
    }
    
    public void PauseGame(InputAction.CallbackContext context)
    {
        _pauseMenuCanvas.SetActive(!_pauseMenuCanvas.activeSelf);
    }
}
