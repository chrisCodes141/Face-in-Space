using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainBackExit : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("3");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
