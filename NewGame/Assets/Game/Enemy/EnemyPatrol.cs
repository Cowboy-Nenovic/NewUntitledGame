using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public GameObject patrolPointA;
    public GameObject patrolPointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float velocity = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = patrolPointB.transform;


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if(currentPoint == patrolPointB.transform)
        {
            rb.velocity = new Vector2(velocity,0);
        }
        else
        {
            rb.velocity = new Vector2(-velocity,0);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == patrolPointB.transform)
        {
            currentPoint = patrolPointA.transform;            
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == patrolPointA.transform)
        {
            currentPoint = patrolPointB.transform;            
        }




    }
}
