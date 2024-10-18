using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI : MonoBehaviour
{

    public PlayerHealth healthValue;
    public TMP_Text healthDisplay;
    public TMP_Text weaponEquiped;
    public TMP_Text weaponAmmo;
    public TMP_Text notification;
    public GunHolder gunHolder;
    public string example = "example";

    // Start is called before the first frame update
    void Start()
    {
  
        healthDisplay.text = "HP:" + healthValue.health;
        weaponEquiped.text = "None";
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "HP:" + healthValue.health;
        weaponEquiped.text = "" + gunHolder.weaponData.name;
        if (!gunHolder.weaponData.reloadState){
            weaponAmmo.text = "" + gunHolder.weaponData.currentAmmo + " / " + gunHolder.weaponData.magazineSize;
        }
        if (gunHolder.weaponData.reloadState){
            weaponAmmo.text = "Reloading / " + gunHolder.weaponData.magazineSize;
        }
    }
    public void setNotification(string noteDisplay){
        notification.text = "" + noteDisplay;
    }
    public void unsetNotification(){
        notification.text = "";
    }
}
