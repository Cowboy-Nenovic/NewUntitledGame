using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TT33 : MonoBehaviour
{

    public string name = "TT-33";
    public int damageStrength = 35;
    public bool categoryPrimary = false;
    public bool semiAuto = false;
    public float timeBetweenFiring = 0.2f;
    public int Magazine = 7;
    public float bulletSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float getRPM()
    {
        return timeBetweenFiring;
    }
}
