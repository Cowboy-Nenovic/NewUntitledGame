using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletTransform;
    public float timeToShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToShoot += Time.deltaTime;
        if (timeToShoot > 2)
        {
            timeToShoot = 0;
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(bullet, bulletTransform.position, Quaternion.identity);
    }
}
