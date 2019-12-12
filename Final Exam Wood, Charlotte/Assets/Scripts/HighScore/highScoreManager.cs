using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreManager : MonoBehaviour
{
    public Text HighScores;
    // Start is called before the first frame update
    void Start()
    {

        setupScores();
    }

    void setupScores()
    {
        HighScores.text = ReadFile.readScores();
    }
}
