using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDownBotEx : MonoBehaviour
{

    public float timer = .1f;

    void Update()
    {
        timer -= Time.deltaTime;
        //timerSeconds.text = timer.ToString("f2");
        //timerSeconds.text = "h";
        if (timer <= 0)
        {
            SceneManager.LoadScene("pvp");
        }
    }
}