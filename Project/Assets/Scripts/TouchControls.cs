using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private PlayerController thePlayer;
    private LevelLoader levelLoad;
    private PauseMenu pause;
    private GameObject touchScreen;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        levelLoad = FindObjectOfType<LevelLoader>();
        pause = FindObjectOfType<PauseMenu>();
        Debug.Log(thePlayer);
    }
    public void LeftArrow()
    {
        thePlayer.Move(-1);
    }
    public void RightArrow()
    {
        Debug.Log("Moving right");
        thePlayer.Move(1);
    }
    public void UpArrow()
    {
        thePlayer.Jump();
        levelLoad.load();
    }
    public void ReleasedArrow()
    {
        thePlayer.Move(0);
    }
    public void Pause()
    {
        pause.Pause();
    }
}
