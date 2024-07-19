using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{

    //private int maxHealth = 100;
    //private int timeToRegenerate = 10;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void setDamage (int damageValue)
    {
        health = health - damageValue;
    }    
  
}
