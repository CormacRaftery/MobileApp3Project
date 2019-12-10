using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    MainMenu mm = new MainMenu();
    public GameObject playerMario;
    public GameObject playerLuigi;
    // Start is called before the first frame update
    void Start()
    {
        if (!mm.getSprite())
        {
            playerMario.SetActive(false);
            playerLuigi.SetActive(true);
        }
        else
        {
            playerMario.SetActive(true);
            playerLuigi.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
