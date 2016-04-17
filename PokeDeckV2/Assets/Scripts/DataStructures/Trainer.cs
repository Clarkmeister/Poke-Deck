using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Trainer : MonoBehaviour
{
    //Data Members:
    public string FilePath { get; set; }
    public string TrainerName { get; set; }
    public Deck PlayerDeck { get; set; }
    string m_Password;
    bool m_passwordSetValid;

    public Trainer()
    {
        PlayerDeck = new Deck();
        m_passwordSetValid = true;
    }

    public void SetPassword(string newPassword)
    {
        if(m_passwordSetValid)
        {
            //Convert Password To Char Array For Easy Binary Storage.
            m_Password = newPassword; 
            m_passwordSetValid = false;
        }
        else
        {
            Debug.Log("Password Not Able To Be Set.");
        }
    }

    //I Tried Writing As Binary but it showed up as ASCII in the written file.
    public void SaveTrainer()
    {
        FileInfo settingsFile = new FileInfo(FilePath + "\\playerData.txt");

        string NL = Environment.NewLine;
        //Add NL between any variable and it will be replaced with a "\n" equivelant.
        string stringToBeWritten = FilePath + NL + TrainerName + NL + PlayerDeck.DeckNumber + NL + m_Password;

        File.WriteAllText(settingsFile.FullName, stringToBeWritten);
    }
}
