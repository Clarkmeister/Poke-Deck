using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour
{
    public GameObject player;
    string _trainerName;
    string _trainerFilePath;

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

	
}
