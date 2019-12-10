using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    private bool playerInZone;

    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && playerInZone)
        {
            load();
            //Application.LoadLevel(levelToLoad);
           // SceneManager.LoadScene(levelToLoad);
        }
    }
    public void load()
    {
        if (playerInZone)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Mario" || other.name == "Luigi")
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Mario" || other.name == "Luigi")
        {
            playerInZone = false;
        }
    }
}
