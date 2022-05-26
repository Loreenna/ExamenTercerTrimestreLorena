using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletspeed;

    private Rigidbody2D rbody;

    private GameManager gameManager;

    void Awake()
    {

        rbody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    /*Mover bala*/
    void Start()
    {
        
        rbody.AddForce(transform.right * bulletspeed, ForceMode2D.Impulse);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Goombas")
        {
	    /*Destruir enemigos*/
            Destroy(gameObject);
            gameManager.DeathGoomba(collider.gameObject);

        }
        
         if(collider.gameObject.tag == "Monedas")
        {        
	/* en blanco para evitar que destruyas las monedas*/
        }
        else
        {

            
            Destroy(gameObject);

        }

        

    }
}