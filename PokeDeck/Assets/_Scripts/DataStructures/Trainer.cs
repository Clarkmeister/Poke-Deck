using UnityEngine;
using System.Collections;

public class Trainer : ScriptableObject
{
    
    //Used for accessing PlayerPrefs
    string _DefaultTrainerTag = "POKEDECKTRAINER";
    string _PasswordTag = "PASSWORD";
    string _DeckTag = "DECK";
    public string Name { get; set; }
    string Password { get; set; }
    public int DeckNumber { get; set; }

    public void SetPassword(string newPw)
    {
        Password = newPw;
    }

    public void SaveTrainer()
    {
        PlayerPrefs.SetString((_DefaultTrainerTag + Name), Name);
        PlayerPrefs.SetString((_DefaultTrainerTag + Name + _PasswordTag), Password);
        PlayerPrefs.SetInt((_DefaultTrainerTag + Name + _DeckTag), DeckNumber);
    }

    public bool isTrainerLoginValid(string name, string password)
    {
        if(PlayerPrefs.GetString((_DefaultTrainerTag + name), "null") == "null")
        { return false; }
        if(PlayerPrefs.GetString(_DefaultTrainerTag + name + _PasswordTag, "null") != password)
        { return false; }
        return true;
    }
    public void LoadTrainer(string name)
    {
        Name = PlayerPrefs.GetString(_DefaultTrainerTag + name);
        Password = PlayerPrefs.GetString(_DefaultTrainerTag + name + _PasswordTag);
        DeckNumber = PlayerPrefs.GetInt(_DefaultTrainerTag + Name + _DeckTag);
    }
}
