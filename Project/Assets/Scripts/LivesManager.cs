using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LivesManager : MonoBehaviour
{
    Text text;
    public static int livesLeft = 9;
    void Start()
    {
        text = GetComponent<Text>();
        livesLeft = 9;
    }

    void Update()
    {
        livesLeft = KillPlayer.livesLeft;
        text.text = "00" + livesLeft;
        if (livesLeft == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Defeat");
    }
}
