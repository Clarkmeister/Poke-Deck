using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ChangeAudioSourceVolume : MonoBehaviour
{
    GameData m_gameData;
    public Slider m_MusicVolumeSlider;
    float m_entranceVolume;

    void Start()
    {
        GameObject data = GameObject.Find("GameData");
        m_gameData = data.GetComponent<GameData>();
        m_entranceVolume = m_gameData.m_GameMusic.volume;
        m_MusicVolumeSlider.value = m_gameData.m_GameMusic.volume;
        Debug.Log(m_gameData.m_GameMusic.volume);
    }

    public void VolumeSliderMusic()
    {
        m_gameData.m_GameMusic.volume = m_MusicVolumeSlider.value;
        m_gameData.SetMusicVolume(m_gameData.m_GameMusic.volume); 
    }

    public void SaveChangedSettings()
    {
        m_entranceVolume = m_gameData.m_GameMusic.volume;
        m_gameData.SaveAll();
    }

    public void OnSettingsExit()
    {
        m_gameData.m_GameMusic.volume = m_entranceVolume;
        m_gameData.SetMusicVolume(m_entranceVolume);
    }
}
