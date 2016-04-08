using UnityEngine;
using System.Collections;
using System.IO;


public class LoginInputGather : MonoBehaviour {
    bool _exists;
    string _username;
    string _directory;
    string _userFileName;
    string _passWord;
    string _filePassword;
    public UnityEngine.UI.InputField TrainerName;
    public UnityEngine.UI.InputField Password;
    public UnityEngine.UI.Text InvalidPassword;
    public UnityEngine.UI.Text InvalidUsername;
    public PlayerData Trainer;

    // Use this for initialization
    void Start () {
	
	}
	// Update is called once per frame
	public void LogInAttempt () {
        InvalidPassword.gameObject.SetActive(false);
        InvalidUsername.gameObject.SetActive(false);
        _username = TrainerName.text;
        
        _username = _username.ToLower();
        Debug.Log(_username);
        _passWord = Password.text;
        Debug.Log(_passWord);
        _directory = Directory.GetCurrentDirectory();
        
        _userFileName = _directory + "\\trainers\\" + _username + "\\" + _username + ".txt";
        Debug.Log(_userFileName);
        FileInfo userFileInfo = new FileInfo(_userFileName);
        if(userFileInfo.Exists)
        {
            Debug.Log("File Exists!");
            _filePassword = File.ReadAllText(_userFileName);
            Debug.Log(_filePassword);
            if(_filePassword == _passWord)
            {
                Trainer.TrainerFilePath = _directory + "\\trainers\\" + _username;
                Trainer.TrainerName = TrainerName.text;
                ChangeScene success = new ChangeScene();
                success.ChangeToScene(1);
            }
            else
            {
                InvalidPassword.gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.Log("File Does Not Exist!");
            InvalidUsername.gameObject.SetActive(true);
        }
    }
}
