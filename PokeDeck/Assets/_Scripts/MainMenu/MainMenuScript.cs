using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{

    PokeDeckData _GameData;
    GameObject PlayButton;
    //PlayerOne:
    GameObject PlayerOneDetails;
    GameObject PlayerOneLogin;
    GameObject PlayerOneCreate;
    GameObject PlayerOneLoginInvalidPassword;
    Text PlayerOneDetailsName;
    InputField PlayerOneLoginName;
    InputField PlayerOneLoginPassword;

    //PlayerTwo:
    GameObject PlayerTwoDetails;
    GameObject PlayerTwoLogin;
    GameObject PlayerTwoCreate;
    GameObject PlayerTwoLoginInvalidPassword;
    Text PlayerTwoDetailsName;
    InputField PlayerTwoLoginName;
    InputField PlayerTwoLoginPassword;

    // Use this for initialization
    void Start()
    {
        GameObject data = GameObject.Find("PokeDeckGameData");
        _GameData = data.GetComponent<PokeDeckData>();
        data = GameObject.Find("PlayerOneDetailsNameText");
        PlayerOneDetailsName = data.GetComponent<Text>();
        data = GameObject.Find("PlayerTwoDetailsNameText");
        PlayerTwoDetailsName = data.GetComponent<Text>();
        data = GameObject.Find("P1LoginInputField");
        PlayerOneLoginName = data.GetComponent<InputField>();
        data = GameObject.Find("P1LoginPWInputField");
        PlayerOneLoginPassword = data.GetComponent<InputField>();
        data = GameObject.Find("P2LoginInputField");
        PlayerTwoLoginName = data.GetComponent<InputField>();
        data = GameObject.Find("P2LoginPWInputField");
        PlayerTwoLoginPassword = data.GetComponent<InputField>();

        PlayButton = GameObject.Find("PlayButtonBorder");
        PlayerOneDetails = GameObject.Find("PlayerOneDetails");
        PlayerOneCreate = GameObject.Find("PlayerOneCreate");
        PlayerOneLogin = GameObject.Find("PlayerOneLogin");
        PlayerTwoDetails = GameObject.Find("PlayerTwoDetails");
        PlayerTwoCreate = GameObject.Find("PlayerTwoCreate");
        PlayerTwoLogin = GameObject.Find("PlayerTwoLogin");
        PlayerOneLoginInvalidPassword = GameObject.Find("InvalidPasswordP1");
        PlayerTwoLoginInvalidPassword = GameObject.Find("InvalidPasswordP2");
        PlayerOneLogin.SetActive(false);
        PlayerTwoLogin.SetActive(false);
        UpdateDetails();
        DetermineActiveMenus();
    }
    
    void Update()
    {
        if(PlayerOneDetails.activeSelf && PlayerTwoDetails.activeSelf)
        {
            PlayButton.SetActive(true);
        }
        else
        {
            PlayButton.SetActive(false);
        }
    }
    public void DetermineActiveMenus()
    {
        //PlayerOneBoxes:
        if(_GameData.PlayerOne.Name == null)
        {
            PlayerOneLogin.SetActive(false);
            PlayerOneCreate.SetActive(true);
            PlayerOneDetails.SetActive(false); }
        else
        {
            PlayerOneLogin.SetActive(false);
            PlayerOneCreate.SetActive(false);
            PlayerOneDetails.SetActive(true); }

        //PlayerTwoBoxes:
        if (_GameData.PlayerTwo.Name == null)
        {
            PlayerTwoLogin.SetActive(false);
            PlayerTwoCreate.SetActive(true);
            PlayerTwoDetails.SetActive(false); }
        else
        {
            PlayerTwoLogin.SetActive(false);
            PlayerTwoCreate.SetActive(false);
            PlayerTwoDetails.SetActive(true);
        }
    }

    public void SetPlayerOne()
    { _GameData.SetPlayerOneActive(); }
    public void SetPlayerTwo()
    { _GameData.SetPlayerTwoActive(); }

    void UpdateDetails()
    {
        PlayerOneDetailsName.text = _GameData.PlayerOne.Name;
        PlayerTwoDetailsName.text = _GameData.PlayerTwo.Name;
    }

    public void Logout()
    {
        _GameData.CurrentTrainer.SaveTrainer();
        if(_GameData.IsPlayerOneActive())
        {
            Destroy(_GameData.PlayerOne);
            _GameData.PlayerOne = ScriptableObject.CreateInstance<Trainer>();
            _GameData.CurrentTrainer = _GameData.PlayerOne;
        }
        else
        {
            Destroy(_GameData.PlayerTwo);
            _GameData.PlayerTwo = ScriptableObject.CreateInstance<Trainer>();
            _GameData.CurrentTrainer = _GameData.PlayerTwo;
        }
        DetermineActiveMenus();
    }

    public void ShowLogin()
    {
        if(_GameData.IsPlayerOneActive())
        {
            PlayerOneLoginInvalidPassword.SetActive(false);
            PlayerOneCreate.SetActive(false);
            PlayerOneDetails.SetActive(false);
            PlayerOneLogin.SetActive(true);
        }
        else
        {
            PlayerTwoLoginInvalidPassword.SetActive(false);
            PlayerTwoCreate.SetActive(false);
            PlayerTwoDetails.SetActive(false);
            PlayerTwoLogin.SetActive(true);
        }
    }
    public void LoginAttempt()
    {
        if(_GameData.IsPlayerOneActive())
        {
            if(_GameData.CurrentTrainer.isTrainerLoginValid(PlayerOneLoginName.text, PlayerOneLoginPassword.text))
            {
                _GameData.CurrentTrainer.LoadTrainer(PlayerOneLoginName.text);
                PlayerOneLogin.SetActive(false);
                UpdateDetails();
                DetermineActiveMenus();
                PlayerOneLoginName.text = "";
                PlayerOneLoginPassword.text = "";
            }
            else
            {
                PlayerOneLoginInvalidPassword.SetActive(true);
            }
        }
        else
        {
            if (_GameData.CurrentTrainer.isTrainerLoginValid(PlayerTwoLoginName.text, PlayerTwoLoginPassword.text))
            {
                _GameData.CurrentTrainer.LoadTrainer(PlayerTwoLoginName.text);
                PlayerTwoLogin.SetActive(false);
                UpdateDetails();
                DetermineActiveMenus();
                PlayerTwoLoginName.text = "";
                PlayerTwoLoginPassword.text = "";      
            }
            else
            {
                PlayerTwoLoginInvalidPassword.SetActive(true);
            }
        }
    }
}
