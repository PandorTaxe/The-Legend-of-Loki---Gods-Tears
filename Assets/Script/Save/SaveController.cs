using System.IO;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    private string saveLocation;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
        // Debug.Log("Player" + _player.GetComponentInChildren<PlayerManager>().transform.position);
        // Debug.Log("Camera" + _player.GetComponentInChildren<Camera>().transform.position);
        // Debug.Log(_player.name);
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        LoadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData
        {
            _playerPosition = _player.GetComponentInChildren<PlayerManager>().transform.position,
            _cameraPosition = _player.GetComponentInChildren<Camera>().transform.position,
        };
        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
    }

    public void LoadGame()
    {
        if (File.Exists(saveLocation))
        {
            SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));
            _player.GetComponentInChildren<PlayerManager>().transform.position = saveData._playerPosition;
            _player.GetComponentInChildren<Camera>().transform.position = saveData._cameraPosition;
        }
        else
        {
            SaveGame();
        }
    }
}
