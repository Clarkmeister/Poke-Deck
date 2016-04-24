using UnityEngine;
using System.Collections;

public class ConstantYRotate : MonoBehaviour {

    public GameObject thisObject;

    // Update is called once per frame
    void Update()
    {
        thisObject.transform.Rotate(.5f, .0f, .0f);
    }
}
