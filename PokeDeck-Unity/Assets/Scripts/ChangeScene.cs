using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
	// Update is called once per frame
	public void ChangeToScene (int sceneToChangeTo)
	{
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(sceneToChangeTo);
#pragma warning restore CS0618 // Type or member is obsolete
    }
    
}
