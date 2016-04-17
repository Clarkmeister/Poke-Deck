using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System;

public class GameSettings : MonoBehaviour {

    public string FilePath { get; set; }

    //Default Unity Volume Range is 0f - 1f.
    public float MusicVolume { get; set; }
    public float SoundFXVolume { get; set; }

    //Requires A File Path For Easy Creation.
    public GameSettings(string newFilePath)
    {
        FilePath = newFilePath;
    }
    //Creates Default Game Setting Values If None Exist.
    public void CreateDefaultSettings()
    {
        //List Of Default Settings:
        //Order Must Match LoadSettings() Order.
        MusicVolume = .5f;
        SoundFXVolume = .5f;

        //Save Settings.
        SaveSettings();
    }
    //LoadsSettings From File
    public void LoadSettings()
    {
        string[] settingsFromFile = File.ReadAllLines(FilePath + "\\gameSettings.txt");

        //Do Not Change Order Please Append Any New Settings To The End.
        MusicVolume = Convert.ToSingle(settingsFromFile[0]);
        SoundFXVolume = Convert.ToSingle(settingsFromFile[1]);
    }
    //Saves Current Values For Game Settings.
    public void SaveSettings()
    {
        FileInfo settingsFile = new FileInfo(FilePath + "\\gameSettings.txt");

        string NL = Environment.NewLine;
        //Add Variables Here Use NL as a newline.
        string writeString = MusicVolume + NL + SoundFXVolume.ToString();

        File.WriteAllText(settingsFile.FullName, writeString);
    }
}
