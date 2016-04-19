using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateMainMenu : MonoBehaviour {
    GameData m_gameData;
    Button m_TrainerOneButton;
    Button m_TrainerOneLogin;
    Button m_TrainerTwoButton;
    Button m_TrainerTwoLogin;
	// Use this for initialization
	void Start () {
        //Find Main Menu Objects.
        GameObject data = GameObject.Find("GameData");
        m_gameData = data.GetComponent<GameData>();
        data = GameObject.Find("TrainerOneButton");
        m_TrainerOneButton = data.GetComponent<Button>();
        data = GameObject.Find("TrainerTwoButton");
        m_TrainerTwoButton = data.GetComponent<Button>();
        data = GameObject.Find("PlayerOneLogin");
        m_TrainerOneLogin = data.GetComponent<Button>();
        data = GameObject.Find("PlayerTwoLogin");
        m_TrainerTwoLogin = data.GetComponent<Button>();

        SetActives();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetActives()
    {
        Debug.Log(m_gameData.isTrainerOneEmpty());
        Debug.Log(m_gameData.m_Trainers.TrainerOne.TrainerName);
        if (m_gameData.isTrainerOneEmpty())
        {
            m_TrainerTwoLogin.interactable = false;
            m_TrainerTwoButton.interactable = false;
        }
        else
        {
            m_TrainerTwoButton.interactable = true;
            m_TrainerTwoLogin.interactable = true;
        }
    }
}
