using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//hello.test

public class ChangeScene : MonoBehaviour
{
    public void ChangeToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void GoToSplashScreen()
    {
        SceneManager.LoadScene("SplashScreen");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToAndUpdateMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
