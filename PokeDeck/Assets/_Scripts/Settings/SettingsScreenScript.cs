using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SettingsScreenScript : MonoBehaviour {

    PokeDeckData _GameData;
    Slider _MasterVolumeSlider;
    Slider _MusicVolumeSlider;

	// Use this for initialization
	void Start () {
        GameObject data = GameObject.Find("PokeDeckGameData");
        _GameData = data.GetComponent<PokeDeckData>();
        data = GameObject.Find("MasterVolumeSlider");
        _MasterVolumeSlider = data.GetComponent<Slider>();
        data = GameObject.Find("MusicVolumeSlider");
        _MusicVolumeSlider = data.GetComponent<Slider>();
        _MasterVolumeSlider.value = _GameData.GameSettings.MasterVolume;
        _MusicVolumeSlider.value = _GameData.GameSettings.MusicVolume;

    }
	
    public void MasterVolumeUpdater()
    {
        _GameData.GameSettings.MasterVolume = _MasterVolumeSlider.value;
        AudioListener.volume = _GameData.GameSettings.MasterVolume;
    }

    public void MusicVolumeUpdater()
    {
        _GameData.GameSettings.MusicVolume = _MusicVolumeSlider.value;
        _GameData.BackgroundMusic.volume = _GameData.GameSettings.MusicVolume;
    }

}
