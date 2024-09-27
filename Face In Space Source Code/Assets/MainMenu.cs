using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayerVsPlayer()
    {
        Debug.Log("Made it to playervsplayer method");
        SceneManager.LoadScene("3");
    }

    public void PlayerVsAI()
    {
        Debug.Log("Made it to playervsAi");
        SceneManager.LoadScene("PvsAI");
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
