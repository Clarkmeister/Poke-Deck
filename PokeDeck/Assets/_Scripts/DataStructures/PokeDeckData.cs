using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokeDeckData : MonoBehaviour
{
	public Trainer PlayerOne { get; set; }
	public Trainer PlayerTwo { get; set; }
    public Trainer CurrentTrainer { get; set; }
	public Settings GameSettings { get; set; }
    public AudioSource BackgroundMusic;

	void Start ()
	{
		DontDestroyOnLoad(this);
		PlayerOne = ScriptableObject.CreateInstance<Trainer>();
		PlayerTwo = ScriptableObject.CreateInstance<Trainer>();
		GameSettings = ScriptableObject.CreateInstance<Settings>();
        GameSettings.LoadSettings();
        AudioListener.volume = GameSettings.MasterVolume;
        BackgroundMusic.volume = GameSettings.MusicVolume;
        PlayerOne.Name = "PlayerOne";
        PlayerTwo.Name = "PlayerTwo";
    }

    //Sets CurrentTrainer to Desired Player.
    public void SetPlayerOneActive()
    { CurrentTrainer = PlayerOne; }
    public void SetPlayerTwoActive()
    { CurrentTrainer = PlayerTwo; }
    //Bools To See If Player Is CurrentTrainer.
    public bool IsPlayerOneActive()
    { if(CurrentTrainer == PlayerOne) { return true; } /*else*/return false; }
    public bool IsPlayerTwoActive()
    { if(CurrentTrainer == PlayerTwo) { return true; } /*else*/return false; }

	//Automatically Called When Game Exits
	void OnApplicationQuit()
	{
		Debug.Log("Application Quit Automatically Saves PlayerPrefs");
	}

    public void DummyTestingFillInData()
    {
        PlayerOne.Name = "PlayerOne";
        PlayerTwo.Name = "PlayerTwo";
        CurrentTrainer = PlayerOne;
    }
}
