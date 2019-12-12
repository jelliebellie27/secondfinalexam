using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadIntro()
    {
        Debug.Log("Loaded Intro");
        SceneManager.LoadScene("1Intro");
    }
    public void loadHIghScores()
    {
        Debug.Log("Loaded High Scores");
        SceneManager.LoadScene("2HighScores");
    }
    public void loadGame()
    {
        Debug.Log("Loaded Game");
        SceneManager.LoadScene("3Game");
    }
    public void loadExit()
    {
        Debug.Log("Loaded Exit");
        SceneManager.LoadScene("4Exit");
    }
    public void ExitProgram()
    {
        //works only for debug, since emulator does not acutaly quit
        Debug.Log("Program exited");
        Application.Quit();
    }

}
