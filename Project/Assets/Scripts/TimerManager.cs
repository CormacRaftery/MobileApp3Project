using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    Text text;
    public static float timeLeft = 360.0f;
    void Start()
    {
        text = GetComponent<Text>();
        timeLeft = 360.0f;
    }

    void Update()
    {
        text.text = "" + (int)timeLeft;
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Defeat");
    }
}
