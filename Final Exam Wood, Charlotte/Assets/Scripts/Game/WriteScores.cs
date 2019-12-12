using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;
//
public class WriteScores : MonoBehaviour
{
    int scorerNumber = 1;

    void Start()
    {

    }


    public static void WriteTheScores()
    {
        Debug.Log("The function Started");
        string[] readText;
        string[] fields;
        bool currentScoreWritten = false;
        string path = "Assets/scores.txt";

        readText = File.ReadAllLines(path);
        Debug.Log("Working Up Here");

        StreamWriter writer = new StreamWriter(path);
        foreach (string line in readText)
        {
            fields = line.Split(',');
            if (Convert.ToInt32(fields[0]) < ScoreKeeper.newScore && currentScoreWritten == false)
            {
                Debug.Log("Here");
                writer.Write(ScoreKeeper.newScore);
                writer.Write(',');
                writer.Write(ReadScores.thePlayerName);
                writer.Write("\n");
                writer.Write(line + "\n");
                currentScoreWritten = true;
            }
            else
            {
                Debug.Log("The Else");
                writer.Write(line + "\n");
            }

        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("scores updated");


    }

    public void WriteTheScoresForButton()
    {
        Debug.Log("The function Started");
        string[] readText;
        string[] fields;
        bool currentScoreWritten = false;
        string path = "Assets/scores.txt";

        readText = File.ReadAllLines(path);
        Debug.Log("Working Up Here");

        StreamWriter writer = new StreamWriter(path);
        foreach (string line in readText)
        {
            fields = line.Split(',');
            if (Convert.ToInt32(fields[0]) < ScoreKeeper.newScore && currentScoreWritten == false)
            {
                Debug.Log("Here");
                writer.Write(ScoreKeeper.newScore);
                writer.Write(',');
                writer.Write(ReadScores.thePlayerName);
                writer.Write("\n");
                writer.Write(line + "\n");
                currentScoreWritten = true;
            }
            else
            {
                Debug.Log("The Else");
                writer.Write(line + "\n");
            }

        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("scores updated");


    }
}
