using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI : MonoBehaviour
{

    public PlayerHealth healthValue;
    public TMP_Text healthDisplay;
    public TMP_Text weaponEquiped;
    public Inventory inventoryPlayer;
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
        weaponEquiped.text = "" + inventoryPlayer.getWeaponSelected();
        healthDisplay.text = "HP:" + healthValue.health;
    }
}
