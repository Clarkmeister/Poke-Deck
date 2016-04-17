using UnityEngine;
using System.Collections;

public class DontDestroyThisObject : MonoBehaviour {
	void Start ()
    {
        DontDestroyOnLoad(gameObject);
	}
}
