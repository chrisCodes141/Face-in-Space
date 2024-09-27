using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;
    public GameObject player;

    private bool FalseAtFirst = false;

    public float x = 3f, y = 3f, z = 0;

    private float seconds = 3;

    void Update()
    {
        Debug.Log("we r updating");
        Debug.Log(FalseAtFirst);
        if(GameObject.Find("PlayerOriginal(Clone)").transform.position.y < -9f)
        {
            SceneManager.LoadScene("PlayAgainBackExit");
        }
        /* sht dont work
        if (FalseAtFirst)
        {
            Debug.Log("WE GOT INSIDE THE IF"+FalseAtFirst);
            while (seconds > 0)
            {
                seconds -= Time.deltaTime;
            }
            SceneManager.LoadScene("PlayAgainBackExit");
        }*/

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        player.transform.localScale = new Vector3(x = x - .25f, y = y - .25f, z);

        if (health <= 0)
        {
            Die();
        }
    }
    //dont destroy game object jus make invisible<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    void Die()
    {

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        /*
        //TO HAVE DELAY BEFORE LOADING SCENE (mutliple ways..)

        //one way
        FalseAtFirst = true;
        Debug.Log(FalseAtFirst);

        //another way
        //this.deathEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);

        //ampther way
        Time.timeScale = 0.5f; // for slow motion
        while(seconds > 0)
        {
            Debug.Log("Inside while"+seconds);
            seconds -= Time.deltaTime;
        }
        
        //another way
        //StartCoroutine("RespawnBall");

        //another way
        Invoke("RestartGame", 3f);

        */
    }

    /*IEnumerator RespawnBall()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("PlayAgainBackExit");
    }
    void RestartGame()
    {
        Debug.Log("We made it to Restart Game Method"); 
        SceneManager.LoadScene("PlayAgainBackExit");
    }
    */
}
