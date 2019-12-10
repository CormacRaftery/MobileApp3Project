using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGame;

    public string levelSelect;
    public string level1;
    public string level2;
    public string level3;
    public string howToPlay;
    public string settings;
    public string back;
    //private PlayerSelector ps;
    private static bool sprite = true;

    public bool getSprite()
    {
        return sprite;
    }

    public void NewGame()
    {
        SceneManager.LoadScene(level1);
        ScoreManager.Reset();
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
        ScoreManager.Reset();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MusicOn()
    {

        Music.changeIsPlayingOn();

    }

    public void MusicOff()
    {
        Music.changeIsPlayingOff();
    
    }

    public void Mario()
    {
        //ps.sprite = true;
    //    ps.setSpriteTrue();
        sprite = true;
    }

    public void Luigi()
    {
         sprite = false;
       // ps.setSpriteFalse();
    }

    public void Back()
    {
        SceneManager.LoadScene(back);
    }

    public void Level1()
    {
        SceneManager.LoadScene(level1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(level2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(level3);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(howToPlay);
    }

    public void Settings()
    {
        SceneManager.LoadScene(settings);
    }
}
