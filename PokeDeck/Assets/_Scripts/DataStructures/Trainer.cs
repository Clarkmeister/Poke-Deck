using UnityEngine;
using System.Collections;

public class Trainer : ScriptableObject
{
    //Used for accessing PlayerPrefs
    string _DefaultTrainerTag = "POKEDECKTRAINER";
    public string Name { get; set; }
    
}
