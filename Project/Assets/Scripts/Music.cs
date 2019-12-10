using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource music;
    private static bool isPlaying = true;
    // Start is called before the first frame update
    void Start()
    {
            music.Play();

    }
    void Update()
    {
        if (!isPlaying)
        {
            music.Pause();
        }
        else
        {
            music.UnPause();
        }
    }
    public static void changeIsPlayingOn()
    {
        isPlaying = true;
    }
    public static void changeIsPlayingOff()
    {
        isPlaying = false;

    }
}
