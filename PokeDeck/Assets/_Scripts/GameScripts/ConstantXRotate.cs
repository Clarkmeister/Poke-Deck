using UnityEngine;
using System.Collections;

public class ConstantXRotate : MonoBehaviour {

    public GameObject thisObject;
	
	// Update is called once per frame
	void Update () {
        thisObject.transform.Rotate(.0f, .5f, .0f);
	}
}
