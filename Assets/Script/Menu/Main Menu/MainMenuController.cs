using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private NewGameController _newGameController;
    
    public void ContinueGame()
    {
        _newGameController.OldGame();
        SceneManager.LoadScene(1);
    }
    
    public void NewGame()
    {
        _newGameController.NewGame();
        SceneManager.LoadScene(1);
    }

    public void SettingsMenu()
    {
        
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
