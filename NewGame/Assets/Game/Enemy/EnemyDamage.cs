using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    //private int maxHealth = 100;
    //private int timeToRegenerate = 20;
    public int health = 100;
    private int damageStrength = 15;
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void setDamage (int damageValue)
    {
        health = health - damageValue;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
            playerHealth.setDamage(damageStrength);

    }
  

}
