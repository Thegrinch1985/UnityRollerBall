using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{

    public static float timeLeft = 60.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft <= 0)
        {
         GameOver();
        }
    }
     void GameOver()
{
    SceneManager.LoadScene("GameOver"); // it will reload ur scene, probably this will work as a game restart for your project, you should do some better "game ending thingy" tho
}
}




