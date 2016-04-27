using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigateUI : MonoBehaviour {

    public void ChangeToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitToDesktop()
    {
        /*I was having Loud Squelches when exiting the game. 
         * This will not prevent Squelches in editor but will
         * prevent them in exit of an exe.*/
        GameObject temp = GameObject.Find("PokeDeckGameData");
        AudioSource tempSource = temp.GetComponent<AudioSource>();
        tempSource.Stop();

        Application.Quit();
    }
}
