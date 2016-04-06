using UnityEngine;
using System.Collections;

public class RotateYAxis : MonoBehaviour {
    public int m_xAxis;
    public int m_yAxis;
    public int m_zAxis;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 1, 0);
	}
}
