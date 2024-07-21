using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Gun", menuName= "Weapon/Gun")]
public class WeaponData : ScriptableObject
{
    //Gun Parameters
    public new string name;
    public int damage;
    public int maxRange;

    public int currentAmmo;
    public int magazineSize;
    public bool reloadState;
    public float reloadSpeed;
    public float fireRate;
    public float fireSpeed;
    public bool fullAuto;
    public bool primary;
    
   
}
