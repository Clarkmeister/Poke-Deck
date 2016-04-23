using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokeDeckData : MonoBehaviour
{
	public Trainer PlayerOne { get; set; }
	public Trainer PlayerTwo { get; set; }
	public Settings GameSettings { get; set; }
    public AudioSource BackgroundMusic;


	void Start ()
	{
		DontDestroyOnLoad(this);
		PlayerOne = Trainer.CreateInstance<Trainer>();
		PlayerTwo = Trainer.CreateInstance<Trainer>();
		GameSettings = Settings.CreateInstance<Settings>();
		GameSettings.LoadSettings();
        AudioListener.volume = GameSettings.MasterVolume;
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
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
