using UnityEngine;
using System.Collections;

public class Trainers : MonoBehaviour
{
    public string FilePath { get; set; }
    public Trainer TrainerOne { get; set; }
    public Trainer TrainerTwo { get; set; }

    GameData m_GameData;
    //True = TrainerOne, False = TrainerTwo.
    public bool CurrentPlayerIsPlayerOne { get; set; }

    //Sets File Path To Trainers Folder For Later Use.
    public Trainers(string newFilePath)
    {
        FilePath = newFilePath;
        CurrentPlayerIsPlayerOne = true;
    }
	// Use this for initialization
	void Start () {
        GameObject data = GameObject.Find("GameData");
        m_GameData = data.GetComponent<GameData>();
        if(m_GameData == null)
        {
            Debug.Log("Line 23 of Trainers.cs Did Not Find GameData!");
        }
	}

    public void SetActiveTrainer(bool PlayerOne)
    {
        if(PlayerOne)
        {
            CurrentPlayerIsPlayerOne = true;
            Debug.Log("PlayerOne Active?: " + CurrentPlayerIsPlayerOne);
        }
        else
        {
            CurrentPlayerIsPlayerOne = false;
            Debug.Log("PlayerOne Active?: " + CurrentPlayerIsPlayerOne);
        }
    }


}
