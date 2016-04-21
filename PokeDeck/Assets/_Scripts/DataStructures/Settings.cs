using UnityEngine;
using System.Collections;

public class Settings : ScriptableObject
{
    //Player Pref Tags:
    string MusicVolumeTag = "POKEDECKSETTINGSMUSICVOLUME";
    string MasterVolumeTag = "POKEDECKSETTINGSMASTERVOLUME";

    //Settings Values:
    public float MusicVolume { get; set; }
    public float MasterVolume { get; set; }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat(MasterVolumeTag, MasterVolume);
        PlayerPrefs.SetFloat(MusicVolumeTag, MusicVolume);
        PlayerPrefs.Save();
    }
    public void LoadSettings()
    {
        MusicVolume = PlayerPrefs.GetFloat(MusicVolumeTag, 0.5f);
        MasterVolume = PlayerPrefs.GetFloat(MasterVolumeTag, 0.5f);
    }
    public void RestoreDefaults()
    {
        PlayerPrefs.DeleteAll();
        LoadSettings();
    }
}
