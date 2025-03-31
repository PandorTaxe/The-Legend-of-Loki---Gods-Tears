using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMapWink : MonoBehaviour
{
    [SerializeField] private Image _playerImage;
    [SerializeField] private float _actualWinkTimer;
    private float _winkTimer;
    private bool _isHide = false;

    private void Start()
    {
        _winkTimer = _actualWinkTimer;
    }

    private void Update()
    {
        _actualWinkTimer -= Time.unscaledDeltaTime;
        if (_actualWinkTimer <= 0)
        {
            _isHide = !_isHide;
            Wink();
            _actualWinkTimer = _winkTimer;
        }
    }

    private void Wink()
    {
        if (_isHide)
        {
            _playerImage.color = Color.clear;
        }
        else
        {
            _playerImage.color = Color.white;
        }
    }
}
