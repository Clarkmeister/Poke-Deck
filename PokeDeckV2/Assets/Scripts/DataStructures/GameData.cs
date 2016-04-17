using UnityEngine;
using System.Collections;
using System.IO;

public class GameData : MonoBehaviour
{
    public Trainers m_Trainers { get; set; } //Holds Both Trainers
    public GameSettings m_GameSettings { get; set; } //Holds Game Settings Data
    DirectoryInfo DataDirectory { get; set; } //GameData Directory
    public AudioSource m_GameMusic;
    public ChangeAudioSourceVolume Game_AudioChanger { get; set; }
    
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
        string dataDirectory = Directory.GetCurrentDirectory() + "\\GameData";
        m_GameSettings = new GameSettings(dataDirectory + "\\GameSettings");
        m_Trainers = new Trainers(dataDirectory + "\\Trainers");
        m_Trainers.TrainerOne = new Trainer();
        m_Trainers.TrainerTwo = new Trainer();

        if (Directory.Exists(dataDirectory))
        {
            //Game Data Folder Already Exists.
            DataDirectory = new DirectoryInfo(dataDirectory);
            LoadSettings();
        }
        else
        {
            //Create Directory For Game Data.
            Directory.CreateDirectory(dataDirectory);
            DataDirectory = new DirectoryInfo(dataDirectory);
            CreateDefaultSettings();
        }
        m_GameMusic.volume = m_GameSettings.MusicVolume;
    }

    //If First Time In Game or GameData Folder Gets Deleted.
    void CreateDefaultSettings()
    {
        //Settings Creation/Load
        DataDirectory.CreateSubdirectory(m_GameSettings.FilePath);
        m_GameSettings.CreateDefaultSettings();
        //Trainers Folder/Creation
        DataDirectory.CreateSubdirectory(m_Trainers.FilePath);
    }

    //Load Settings From Folder.
    void LoadSettings()
    { m_GameSettings.LoadSettings(); }

    //Set Music Volume
    public void SetMusicVolume(float newVolume)
    { m_GameSettings.MusicVolume = newVolume; }

    //Save Any Settings That Are Place in GameSettings.SaveSettings().
    public void SaveAll()
    { m_GameSettings.SaveSettings(); }
}
