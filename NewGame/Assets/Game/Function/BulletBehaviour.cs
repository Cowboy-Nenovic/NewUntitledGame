using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float force;
    public int damageStrength;
    public EnemyDamage Enemy;

    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // Find Spawnpoint of Bullet
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rigidbody = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        // Define Trajectory of Bullet
        Vector3 direction = mousePos -transform.position;
        Vector3 rotation =  transform.position - mousePos;

        // Define JebemLiGa
        rigidbody.velocity = new Vector2(direction.x,direction.y).normalized * force;
        float rotate = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotate +90);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyDamage>(out EnemyDamage targetEnemy))
        {
            
            damageStrength = 35;
            targetEnemy.setDamage(damageStrength);
        }
            Destroy(gameObject);
  }
}
