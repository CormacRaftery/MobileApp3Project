using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckPoint;

    private PlayerController player;

    public GameObject deathParticle;
    public GameObject respawnParticle;
    private float gravityStore;
    public int pointPenaltyOnDeath;
    public float respawnDelay;
    private CameraController camera1;    // Start is called before the first frame update

    public AudioSource damage;


    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        camera1 = FindObjectOfType<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Debug.Log("Player Respawn");

        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        camera1.isFollowing = false;
        damage.Play();

        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        yield return new WaitForSeconds(respawnDelay);
        player.enabled = true;
        camera1.isFollowing = true;
        player.GetComponent<Renderer>().enabled = true;
        player.transform.position = currentCheckPoint.transform.position;
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
