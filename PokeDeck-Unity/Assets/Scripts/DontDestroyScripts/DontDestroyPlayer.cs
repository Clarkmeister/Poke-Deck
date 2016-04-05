using UnityEngine;
using System.Collections;

public class DontDestroyPlayer : MonoBehaviour {

    public static DontDestroyPlayer Instance;
    public void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
