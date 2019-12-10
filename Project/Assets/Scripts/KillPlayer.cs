using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;
    Text text;
    public static int livesLeft = 9;

    // Start is called before the first frame update
    void Start()
    {
        livesLeft = 9;
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Mario" || other.name == "Luigi")
        {
            livesLeft--;
            levelManager.RespawnPlayer();
        }
    }
}
