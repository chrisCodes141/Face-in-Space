using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    /* First WAY
    int countdownStartValue = 10;
    public Text TimerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    public void countDownTimer()
    {
        if (countdownStartValue > 0)
        {
            TimerUI.text = countdownStartValue.ToString();
            countdownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            TimerUI.text = "FIGHT";
            SceneManager.LoadScene("pvp");
        }
    }*/

    public float timer = 1f;
    //public Text timerSeconds;

    void Start()
    {
        
    //    timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        //timerSeconds.text = timer.ToString("f2");
        //timerSeconds.text = "h";
        if (timer <= 0)
        {
            SceneManager.LoadScene("2");
        }
    }
}
