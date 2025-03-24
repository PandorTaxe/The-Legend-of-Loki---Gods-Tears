using UnityEngine;
using UnityEngine.UI;

public class PauseTabController : MonoBehaviour
{
    public Image[] _pauseButtons;
    [SerializeField] public GameObject[] _pauseTabs;
    
    private void Start()
    {
        ActivatePauseTab(0);
    }

    public void ActivatePauseTab(int tabnumber)
    {
        for (int i = 0; i < _pauseTabs.Length; i++)
        {
            _pauseTabs[i].SetActive(false);
            _pauseButtons[i].color = Color.gray;
        }
        _pauseTabs[tabnumber].SetActive(true);
        _pauseButtons[tabnumber].color = Color.white;
    }
}
