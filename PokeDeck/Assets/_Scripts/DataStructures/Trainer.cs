using UnityEngine;
using System.Collections;

public class Trainer : ScriptableObject
{
    //Used for accessing PlayerPrefs
    string _DefaultTrainerTag = "POKEDECKTRAINER";
    string _PasswordTag = "PASSWORD";
    public string Name { get; set; }
    string Password { get; set; }

    public void SetPassword(string newPw)
    {
        Password = newPw;
    }

    public void SaveTrainer()
    {
        PlayerPrefs.SetString((_DefaultTrainerTag + Name), Name);
        PlayerPrefs.SetString((_DefaultTrainerTag + Name + Password), Password);
    }
}
