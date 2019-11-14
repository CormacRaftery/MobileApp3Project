using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyStomp : MonoBehaviour
{
    public int damage;
    public AudioSource stomp;
    public float bounceOnEnemy;
    private Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = transform.parent.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemies")
        {
            stomp.Play();
            Destroy(other.gameObject);
            Debug.Log("Stomp");
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, bounceOnEnemy);
        }
        
    }
}
