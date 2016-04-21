using UnityEngine;
using System.Collections;

public class PokeDeckData : MonoBehaviour {

	Trainer m_PlayerOne;
	Trainer m_PlayerTwo;
	Settings m_GameSettings;
	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad(this);
		m_PlayerOne = Trainer.CreateInstance<Trainer>();
		m_PlayerTwo = Trainer.CreateInstance<Trainer>();
		m_GameSettings = Settings.CreateInstance<Settings>();
		m_GameSettings.LoadSettings();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	//Automatically Called When Game Exits
	void OnApplicationQuit()
	{
		Debug.Log("Application Quit Automatically Saves PlayerPrefs");
	}
}
