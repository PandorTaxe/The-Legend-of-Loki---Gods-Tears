using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PauseMenuController : MonoBehaviour
{
    public GameObject _pauseMenuCanvas;
    private bool _isGamePaused = false;

    void Start()
    {
        _pauseMenuCanvas.SetActive(false);
    }
    
    public void PauseGame(InputAction.CallbackContext context)
    {
        _pauseMenuCanvas.SetActive(!_pauseMenuCanvas.activeSelf);
        _isGamePaused = !_isGamePaused;
        if (_isGamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
