using UnityEngine;
using System.Collections;
using System.IO;

public class AttemptAccountCreation : MonoBehaviour
{
    bool _exists;
    string _username;
    string _userNameDirectory;
    string _userFileName;
    string _passWord;
    string _passWordConfirm;
    string _directory;
    public UnityEngine.UI.InputField TrainerNameCreate;
    public UnityEngine.UI.InputField CreatePassword;
    public UnityEngine.UI.InputField CreatePasswordConfirm;
    public UnityEngine.UI.Text UserAlreadyExistsText;
    public UnityEngine.UI.Text NotMatchingPasswords;
    public UnityEngine.UI.InputField TrainerNameLogin;
    public UnityEngine.UI.InputField LoginPassword;
    public GameObject LoginScreen;
    public GameObject CreationScreen;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    public void Attempt()
    {
        Debug.Log("In Attempt");
        _username = TrainerNameCreate.text;
        _username = _username.ToLower();
        Debug.Log(_username);
        _passWord = CreatePassword.text;
        Debug.Log(_passWord);
        _passWordConfirm = CreatePasswordConfirm.text;
        Debug.Log(_passWordConfirm);

        _directory = Directory.GetCurrentDirectory();
        _directory += "\\trainers";
        _userNameDirectory = _directory + "\\" + _username;
        _userFileName = _directory + "\\" + _username + "\\" + _username + ".txt";

        if (!System.IO.Directory.Exists(_directory))
        {
            Debug.Log("Directory Does Not Exist!");
            System.IO.Directory.CreateDirectory(_directory);
        }

        FileInfo userFileInfo = new FileInfo(_userFileName);
        if (userFileInfo.Exists)
        {
            NotMatchingPasswords.gameObject.SetActive(false);
            UserAlreadyExistsText.gameObject.SetActive(true);
            Debug.Log("File Exists!");
        }
        else
        {
            if (_passWordConfirm == _passWord)
            {
                System.IO.Directory.CreateDirectory(_userNameDirectory);
                File.WriteAllText(_userFileName, _passWord);
                CreationScreen.SetActive(false);
                NotMatchingPasswords.gameObject.SetActive(false);
                UserAlreadyExistsText.gameObject.SetActive(false);
                LoginScreen.SetActive(true);
                LoginPassword.text = CreatePassword.text;
                TrainerNameLogin.text = TrainerNameCreate.text;
            }
            else
            {
                UserAlreadyExistsText.gameObject.SetActive(false);
                NotMatchingPasswords.gameObject.SetActive(true);
            }
            Debug.Log("File Does Not Exist!");
        }

    }
}
