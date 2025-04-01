using System.IO;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    [SerializeField] private RectTransform _playerMapTransform;
    [SerializeField] private NewGameController _newGameController;
    private string saveLocation;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
        // Debug.Log("Player" + _player.GetComponentInChildren<PlayerManager>().transform.position);
        // Debug.Log("Camera" + _player.GetComponentInChildren<Camera>().transform.position);
        // Debug.Log(_player.name);
        Debug.Log(_newGameController._isNewGame);
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        if (!_newGameController._isNewGame)
            LoadGame();
        else if (_newGameController._isNewGame)
            SaveGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData
        {
            _playerPosition = _player.GetComponentInChildren<PlayerManager>().transform.position,
            _playerMapPosition = _playerMapTransform.position,
            _cameraPosition = _player.GetComponentInChildren<Camera>().transform.position,
        };
        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
    }

    private void LoadGame()
    {
        if (File.Exists(saveLocation))
        {
            SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));
            _player.GetComponentInChildren<PlayerManager>().transform.position = saveData._playerPosition;
            _player.GetComponentInChildren<Camera>().transform.position = saveData._cameraPosition;
            _playerMapTransform.position = saveData._playerMapPosition;
        }
        else
        {
            SaveGame();
        }
    }

    public void NewGame()
    {
        SaveData saveData = new SaveData
        {
            _playerPosition = new Vector3(0,0,0),
            _playerMapPosition = new Vector3(-61,15,0),
            _cameraPosition = new Vector3(0,0,-10),
        };
        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
    }
}
