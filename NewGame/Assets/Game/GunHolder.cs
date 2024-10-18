using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHolder : MonoBehaviour
{
    [Header ("Refrences")]
     [SerializeField] public WeaponData weaponData;
     Weapon childScript = new Weapon();

    void Update()
    {
        childScript = GetComponentInChildren<Weapon>();
        weaponData = childScript.weaponData;
        
    }
 

}
