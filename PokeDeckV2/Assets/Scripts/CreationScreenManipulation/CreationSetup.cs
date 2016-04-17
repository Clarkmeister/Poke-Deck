using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
public class CreationSetup : MonoBehaviour {

    GameData m_gameData;
    public Text TrainerOne;
    public Text TrainerTwo;
    public Image m_AlreadyExists;
    public Image m_InvalidName;
    public Image m_InvalidPassword;
    public InputField m_TrainerName;
    public InputField m_Password;
    public InputField m_ConfirmPassword;
    public GameObject TrainerCreationBox;
    public GameObject DeckSelectionBox;

	// Use this for initialization
	void Start () {
        //Set All Warnings To Inactive:
        DeckSelectionBox.SetActive(false);
        TrainerCreationBox.SetActive(true);
        TrainerOne.gameObject.SetActive(false);
        TrainerTwo.gameObject.SetActive(false);
        m_AlreadyExists.gameObject.SetActive(false);
        m_InvalidName.gameObject.SetActive(false);
        m_InvalidPassword.gameObject.SetActive(false);

        //Find GameData Object
        GameObject data = GameObject.Find("GameData");
        m_gameData = data.GetComponent<GameData>();

        //Check if Player One or Two, Display On Screen:
        if(m_gameData.m_Trainers.CurrentPlayerIsPlayerOne)
        {
            TrainerOne.gameObject.SetActive(true);
        }
        else
        {
            TrainerTwo.gameObject.SetActive(true);
        }
    }
	
    //Attempts To Create A player.
    public void CreatePlayer()
    {
        ////////Sets any warnings to inactive./////////
        m_AlreadyExists.gameObject.SetActive(false);
        m_InvalidName.gameObject.SetActive(false);
        m_InvalidPassword.gameObject.SetActive(false);
        ///////////////////////////////////////////////

        Trainer temp = new Trainer();

        //Checks for matching passwords:
        if(m_Password.text != m_ConfirmPassword.text)
        { m_InvalidPassword.gameObject.SetActive(true); return; }

        //Checks to see if Trainer Name Length is Greater than four.
        if (m_TrainerName.text.Length < 4)
        { m_InvalidName.gameObject.SetActive(true); return; }

        temp.FilePath = m_gameData.m_Trainers.FilePath + "\\" + m_TrainerName.text;
        Debug.Log(temp.FilePath);
        //Checks to see if Desired Trainer Already Exists.
        if (TrainerExists(temp))
        { m_AlreadyExists.gameObject.SetActive(true); return; }

        //Checks to see if Directory Creation Was Successful.
        if(!Directory.Exists(temp.FilePath))
        { m_InvalidName.gameObject.SetActive(true); return; }

        //**************AFTER THIS POINT PLAYER IS VALID***********//
        //*******SET ANY CRITICAL DEFAULT VALUES TO TEMP HERE******//

        //Sets Default Trainer Values and Save In Case Back Button Is Hit.
        SetDefaultDeck(temp.PlayerDeck);
        temp.TrainerName = m_TrainerName.text;
        temp.SetPassword(m_Password.text);
        temp.SaveTrainer();

        ChooseDeck(temp);
    }

    //If True Trainer Already Exists, Else False and Create Directory.
    bool TrainerExists(Trainer trainer)
    {
        if(Directory.Exists(trainer.FilePath)){return true;}

        Directory.CreateDirectory(trainer.FilePath); return false;
    }

    //Sets Default Deck In Case Player Backs Out.
    public void SetDefaultDeck(Deck deck)
    {
        deck.DeckNumber = 0;
    }

    //Activates Theme Deck Selection.
    void ChooseDeck(Trainer trainer)
    {
        //Makes Sure UI isn't Ugly.
        //******Probably Not Necessary Unless Bug Somewhere*****//
        DeckSelectionBox.SetActive(true);
        TrainerCreationBox.SetActive(false);
        TrainerOne.gameObject.SetActive(false);
        TrainerTwo.gameObject.SetActive(false);
        m_AlreadyExists.gameObject.SetActive(false);
        m_InvalidName.gameObject.SetActive(false);
        m_InvalidPassword.gameObject.SetActive(false);
        //************************************************//

        if (m_gameData.m_Trainers.CurrentPlayerIsPlayerOne)
        { m_gameData.m_Trainers.TrainerOne = trainer; }
        else
        { m_gameData.m_Trainers.TrainerTwo = trainer; }
    }

    public void SetDeckNumber (int number)
    {
        //Check if Player One or Two, Display On Screen:
        if (m_gameData.m_Trainers.CurrentPlayerIsPlayerOne)
        {
            m_gameData.m_Trainers.TrainerOne.PlayerDeck.DeckNumber = number;
        }
        else
        {
            m_gameData.m_Trainers.TrainerTwo.PlayerDeck.DeckNumber = number;
        }
    }
}
