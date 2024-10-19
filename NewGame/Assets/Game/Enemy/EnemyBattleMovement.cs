using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleMovement : MonoBehaviour
{

    private Vector2 coverPosition;
    private Vector2 enemyPosition;
    private Rigidbody2D body;
    private float speed =2;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enviroment");
        coverPosition = gameObjects[0].transform.position;
        enemyPosition = transform.position;
        Vector2 direction = coverPosition - enemyPosition;

        transform.position = Vector2.MoveTowards(this.transform.position, coverPosition, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
