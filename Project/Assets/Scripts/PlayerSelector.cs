﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    MainMenu mm = new MainMenu();
    // private MainMenu mm;
   // private static bool sprite = true;
    public GameObject playerMario;
    public GameObject playerLuigi;
    // Start is called before the first frame update
    void Start()
    {
        // mm = FindObjectOfType<MainMenu>();
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
       /*if (sprite)
       {
           playerMario.SetActive(false);
           playerLuigi.SetActive(true);
       }
       else
       {
           playerMario.SetActive(true);
           playerLuigi.SetActive(false);
       }*/
    }
 /*   public void setSpriteTrue()
    {
        sprite = true;
    }
    public void setSpriteFalse()
    {
        sprite = false;
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
