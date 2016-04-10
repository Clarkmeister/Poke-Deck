using UnityEngine;
using System.Collections;

public class ToTransparent : MonoBehaviour {

    string _ObjectName;
	// Use this for initialization
	void Start () {
        GameObject _this = GameObject.Find(this.name);
        Debug.Log(_this.name += " Is Inactive");
        //_this.active = false;
        _this.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MakeTransparent(GameObject desiredObject)
    {
        Debug.Log(desiredObject.name += " Is Inactive");
        desiredObject.SetActive(false);
    }

    public void MakeActive(GameObject desiredObject)
    {
        Debug.Log(desiredObject.name += " Is Inactive");
        desiredObject.SetActive(true);
    }

}
