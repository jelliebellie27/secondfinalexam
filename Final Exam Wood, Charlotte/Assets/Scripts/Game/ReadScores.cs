using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ReadScores : MonoBehaviour
{
    public Text HighScoreText;
    int scorerNumber = 1;

    public static string thePlayerName;
    public InputField PlayerNameInputField;

    void Update()
    {
        if (Input.anyKey)
        {
            thePlayerName = PlayerNameInputField.text;
            Debug.Log(thePlayerName);
        }


    }


    public void ShowScores()
    {
        int playerScore;
        string playerName;
        string[] readText;
        string[] fields;
        string path = "Assets/scores.txt";



        readText = File.ReadAllLines(path);

        foreach (string line in readText)
        {
            fields = line.Split(',');
            playerScore = Convert.ToInt32(fields[0]);
            playerName = fields[1];

            Debug.Log("playerName: " + playerName);
            if (scorerNumber <= 5 && playerName == (thePlayerName))
            {
                if (scorerNumber == 1)
                {
                    HighScoreText.text = " ";
                }
                HighScoreText.text += scorerNumber + ". " + playerName + " - " + playerScore + "\n";
                scorerNumber++;
                Debug.Log("Match");
            }

        }
        if (scorerNumber == 1)
        {
            HighScoreText.text = "No scores entered for this name";
        }

    }

}
