using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour
{

    PokeDeckData _GameData;
    // Use this for initialization
    void Start()
    {
        GameObject data = GameObject.Find("PokeDeckGameData");
        _GameData = data.GetComponent<PokeDeckData>();
    }

    public void SetPlayerOne()
    { _GameData.SetPlayerOneActive(); }
    public void SetPlayerTwo()
    { _GameData.SetPlayerTwoActive(); }
}
