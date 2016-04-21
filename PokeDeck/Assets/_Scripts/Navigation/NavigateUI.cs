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
        Application.Quit();
    }
}
