using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SettingsScreenScript : MonoBehaviour {

    PokeDeckData _GameData;
    Slider _MasterVolumeSlider;
    Slider _MusicVolumeSlider;
    float _InitialMasterVolume;
    float _InitialMusicVolume;
    GameObject DeleteAllBox;

	// Use this for initialization
	void Start () {
        GameObject data = GameObject.Find("PokeDeckGameData");
        _GameData = data.GetComponent<PokeDeckData>();
        data = GameObject.Find("MasterVolumeSlider");
        _MasterVolumeSlider = data.GetComponent<Slider>();
        data = GameObject.Find("MusicVolumeSlider");
        _MusicVolumeSlider = data.GetComponent<Slider>();
        DeleteAllBox = GameObject.Find("DeleteAllTrainersConfirmPanel");
        _MasterVolumeSlider.value = _GameData.GameSettings.MasterVolume;
        _MusicVolumeSlider.value = _GameData.GameSettings.MusicVolume;
        _InitialMasterVolume = _GameData.GameSettings.MasterVolume;
        _InitialMusicVolume = _GameData.GameSettings.MusicVolume;
        DeleteAllBox.SetActive(false);
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

    public void SaveSettings()
    {
        _GameData.GameSettings.SaveSettings();
    }

    public void RevertSettings()
    {
        _GameData.GameSettings.MasterVolume = _InitialMasterVolume;
        _GameData.GameSettings.MusicVolume = _InitialMusicVolume;
        _GameData.BackgroundMusic.volume = _GameData.GameSettings.MusicVolume;
        AudioListener.volume = _GameData.GameSettings.MasterVolume;
        _GameData.GameSettings.SaveSettings();
    }

    public void ShowDeleteBox()
    {
        DeleteAllBox.SetActive(true);
    }

    public void HideDeleteBox()
    {
        DeleteAllBox.SetActive(false);
    }

    public void DeleteAll()
    {
        _GameData.GameSettings.RestoreDefaults();
        Destroy(_GameData.PlayerOne);
        _GameData.PlayerOne = ScriptableObject.CreateInstance<Trainer>();
        Destroy(_GameData.PlayerTwo);
        _GameData.PlayerTwo = ScriptableObject.CreateInstance<Trainer>();
        _GameData.GameSettings.SaveSettings();
        _GameData.BackgroundMusic.volume = _GameData.GameSettings.MusicVolume;
        AudioListener.volume = _GameData.GameSettings.MasterVolume;
        _MasterVolumeSlider.value = _GameData.GameSettings.MasterVolume;
        _MusicVolumeSlider.value = _GameData.GameSettings.MusicVolume;
        _InitialMasterVolume = _GameData.GameSettings.MasterVolume;
        _InitialMusicVolume = _GameData.GameSettings.MusicVolume;
        DeleteAllBox.SetActive(false);
    }
}
