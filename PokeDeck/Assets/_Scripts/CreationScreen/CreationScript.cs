using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreationScript : MonoBehaviour {

    PokeDeckData _GameData;
    bool _ValidTrainerName; bool _ValidPassWord; bool _MatchingPassword;
    Button CreateTrainerButton;
    //All Warning Images:
    GameObject GreenCheckTrainerName;
    GameObject GreenCheckPassword;
    GameObject RedXTrainerName;
    GameObject RedXPassword;
    GameObject NameToShort;
    GameObject NameAlreadyTaken;
    GameObject PasswordsDontMatch;
    GameObject GreenCheckPasswordLength;
    GameObject RedXPasswordLength;

    InputField PasswordText;
    InputField PasswordConfimText;
    InputField TrainerNameInputField;
    

    // Use this for initialization
    void Start () {
        _ValidPassWord = false;
        _ValidTrainerName = false;
        _MatchingPassword = false;
        GameObject data = GameObject.Find("PokeDeckGameData");
        _GameData = data.GetComponent<PokeDeckData>();
        data = GameObject.Find("CreateButton");
        CreateTrainerButton = data.GetComponent<Button>();
        RedXTrainerName = GameObject.Find("RedXTN");
        GreenCheckTrainerName = GameObject.Find("GreenCheckTN");
        RedXPassword = GameObject.Find("RedXPW");
        GreenCheckPassword = GameObject.Find("GreenCheckPW");
        NameAlreadyTaken = GameObject.Find("AlreadyTaken");
        NameToShort = GameObject.Find("TooShort");
        GreenCheckPasswordLength = GameObject.Find("GreenCheckPassW");
        RedXPasswordLength = GameObject.Find("RedXPassW");
        data = GameObject.Find("PasswordInputField");
        PasswordText = data.GetComponent<InputField>();
        data = GameObject.Find("ValidationPassword");
        PasswordConfimText = data.GetComponent<InputField>();
        data = GameObject.Find("TrainerNameInputField");
        TrainerNameInputField = data.GetComponent<InputField>();
        GreenCheckPasswordLength.SetActive(false);
        RedXPasswordLength.SetActive(false);
        NameToShort.SetActive(false);
        NameAlreadyTaken.SetActive(false);
        RedXTrainerName.SetActive(false);
        GreenCheckTrainerName.SetActive(false);
        GreenCheckPassword.SetActive(false);
        RedXPassword.SetActive(false);
        CreateTrainerButton.interactable = false;
        Debug.Log(_GameData.CurrentTrainer.Name);
    }
	
    public void OnEndTrainerNameEdit(string currentData)
    {
        string playerPrefs = "POKEDECKTRAINER" + currentData;
        RedXTrainerName.SetActive(false);
        NameToShort.SetActive(false);
        NameAlreadyTaken.SetActive(false);
        GreenCheckTrainerName.SetActive(false);

        if (currentData.Length < 5)
        {
            RedXTrainerName.SetActive(true);
            NameToShort.SetActive(true);
            _ValidTrainerName = false;
        }
        else if(PlayerPrefs.GetString(playerPrefs) != "")
        {
            RedXTrainerName.SetActive(true);
            NameAlreadyTaken.SetActive(true);
            _ValidTrainerName = false;
        }
        else
        {
            GreenCheckTrainerName.SetActive(true);
            _ValidTrainerName = true;
        }
    }

    public void OnEndPasswordEdit(string currentData)
    {
        RedXPasswordLength.SetActive(false);
        GreenCheckPasswordLength.SetActive(false);
        if (PasswordText.text.Length < 6)
        {
            RedXPasswordLength.SetActive(true);
            _ValidPassWord = false;
        }
        else
        {
            GreenCheckPasswordLength.SetActive(true);
            _ValidPassWord = true;
        }
    }
    public void OnEndPasswordConfirmEdit(string currentData)
    {
        RedXPassword.SetActive(false);
        GreenCheckPassword.SetActive(false);
        if (PasswordConfimText.text != PasswordText.text)
        {
            RedXPassword.SetActive(true);
            _MatchingPassword = false;
        }
        else
        {
            GreenCheckPassword.SetActive(true);
            _MatchingPassword = true;    
        }
    }

    public void ActivateCreateButton()
    {
        string playerPrefs = "POKEDECKTRAINER" + TrainerNameInputField.text;
        if (TrainerNameInputField.text.Length < 5)
        {
            _ValidTrainerName = false;
        }
        else if (PlayerPrefs.GetString(playerPrefs) != "")
        {
            _ValidTrainerName = false;
        }
        else
        {
            _ValidTrainerName = true;
        }

        if (PasswordText.text.Length < 6)
        {
            _ValidPassWord = false;
        }
        else
        {
            _ValidPassWord = true;
        }
        if (PasswordConfimText.text != PasswordText.text)
        { 
            _MatchingPassword = false;
        }
        else
        {
            _MatchingPassword = true;
        }
        if(IsValidCredintials())
        {
            GreenCheckPasswordLength.SetActive(true);
            RedXPasswordLength.SetActive(false);
            NameToShort.SetActive(false);
            NameAlreadyTaken.SetActive(false);
            RedXTrainerName.SetActive(false);
            GreenCheckTrainerName.SetActive(true);
            GreenCheckPassword.SetActive(true);
            RedXPassword.SetActive(false);
            CreateTrainerButton.interactable = true;
        }
        else
        {
            CreateTrainerButton.interactable = false;
        }      
    }

    bool IsValidCredintials()
    {
        if(!_ValidTrainerName)
        { return false; }
        if(!_ValidPassWord)
        { return false; }
        if(!_MatchingPassword)
        { return false; }

        return true;
    }

    public void CreateThisTrainer()
    {
        _GameData.CurrentTrainer.Name = TrainerNameInputField.text;
        _GameData.CurrentTrainer.SetPassword(PasswordText.text);
        _GameData.CurrentTrainer.SaveTrainer();
    }
}
