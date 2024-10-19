using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Enemy", menuName= "Enemy/Enemy")]
public class EnemyData : ScriptableObject
{
    [Header ("Refrences")]
    [SerializeField] public WeaponData weaponData;
    //Enemy Parameters
    public new string name;
    public int meleeDamage;
    public float meleeSpeed;
    public int detectionRange;
    public float supression;
    public float supressionRate;
    public float supressionRecovery;
    public float skill;
   
}
