using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force = 5;
    private float rotation;
    private int damageStrength = 10;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
     player = GameObject.FindGameObjectWithTag("Player");

     Vector3 direction = player.transform.position - transform.position;
     rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
     rotation = Mathf.Atan2(-direction.y, direction.x) * Mathf.Rad2Deg;
     transform.rotation = Quaternion.Euler(0,0, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth targetEnemy))
        {
            
            targetEnemy.setDamage(damageStrength);
        }
            Destroy(gameObject);
  }
}
