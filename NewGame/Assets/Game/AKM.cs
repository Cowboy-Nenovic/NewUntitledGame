using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKM : MonoBehaviour
{

    public string name = "AKM";
    public int damageStrength = 35;
    public bool categoryPrimary = true;
    public bool semiAuto = true;
    public float timeBetweenFiring = 0.2f;
    public int Magazine = 30;
    public float bulletSpeed = 5;


    // To be implemented
    // public ... recoil
    // public ... range

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
