using UnityEngine;
using System.Collections;

public class DestroyThemeSong : MonoBehaviour
{

    public GameObject AudioObject;

    // Use this for initialization
    void Start()
    {
        AudioObject = GameObject.Find("PokemonTheme");
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(AudioObject);
    }
}