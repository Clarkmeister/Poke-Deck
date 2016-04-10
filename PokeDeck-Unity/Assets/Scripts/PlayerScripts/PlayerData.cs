using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour
{
    public GameObject player;
    string _trainerName;
    string _trainerFilePath;
    string _playerColor;

    public string TrainerName
    {
        get { return _trainerName; }
        set { _trainerName = value; }
    }
    public string TrainerFilePath
    {
        get { return _trainerFilePath; }
        set { _trainerFilePath = value; }
    }

    public string PlayerColor
    {
        get { return _playerColor; }
        set { _playerColor = value; }
    }
}
