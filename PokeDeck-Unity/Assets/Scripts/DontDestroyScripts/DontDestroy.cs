using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

    public static DontDestroy Instance;
	public void Awake()
    {
        if(Instance)
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
