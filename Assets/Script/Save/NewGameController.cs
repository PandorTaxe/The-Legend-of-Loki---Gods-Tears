using System;
using UnityEngine;

public class NewGameController : MonoBehaviour
{
    static bool _isNewGameSelected;
    public bool _isNewGame;

    private void Awake()
    {
        _isNewGame = _isNewGameSelected;
    }

    public void OldGame()
    {
        _isNewGameSelected = false;
    }    
    public void NewGame()
    {
        _isNewGameSelected = true;
    }
}
