using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject akm;
    public GameObject tt33;
    
    public GameObject primary;
    public GameObject secondary;

    public GameObject playerGun;
    public GameObject weaponSelected ;
    public string stringTemp;
    public int intTemp;
    public float floatTemp;

    // Start is called before the first frame update
    void Start()
    {
        primary = akm;
        secondary = tt33;

        weaponSelected = secondary;
        intTemp = 30;
       Instantiate(akm);
       Instantiate(tt33);
       Instantiate(weaponSelected);
        weaponSelected = secondary;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
        weaponSelected = primary;
        
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
        weaponSelected = secondary;
        
        }
        

    }
    public string getWeaponSelected()
    {
        // stringTemp = weaponSelected.name;
        return stringTemp;
    }

    public int getDamange()
    {
      //  intTemp = akm.damageStrength;
        return intTemp;
    }
    public float getRPM()
    {
    //    floatTemp = weaponSelected.timeBetweenFiring;
        return floatTemp;
    }

}
