using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public BoxCollider2D coll;
    public Transform player, gunContainer;
    public Weapon gunScript;
    public float pickUpRange;


    public bool equipped;
    public static bool slotFull;
    //public EqupedGun 
    // Start is called before the first frame update
    void Start()
    {
        if (!equipped)
        {
            rigidbody2D.simulated = true;
            coll.isTrigger = false;
            gunScript.enabled = false;
        }
        if (equipped)
        {
            rigidbody2D.simulated = false;
            coll.isTrigger = true;
            slotFull = true;
            gunScript.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
         //Check if player is in range and "E" is pressed
        Vector2 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp();

        //Drop if equipped and "Q" is pressed
        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();       
    }
     private void PickUp()
    {
        equipped = true;
        slotFull = true;

        //Make weapon a child of the camera and move it to default position
        transform.SetParent(gunContainer);
        transform.localPosition = Vector2.zero;
        transform.localRotation = Quaternion.Euler(Vector2.zero);
        transform.localScale = Vector2.one;

        //Make Rigidbody kinematic and BoxCollider a trigger
        rigidbody2D.simulated = false;
        coll.isTrigger = true;

        //Enable script
        gunScript.enabled = true;
    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;

        //Set parent to null
        transform.SetParent(null);

        //Make Rigidbody not kinematic and BoxCollider normal
        rigidbody2D.simulated = true;
        coll.isTrigger = false;

        //Gun carries momentum of player
      //  rb.velocity = player.GetComponent<Rigidbody>().velocity;

        //Add random rotation
        float random = Random.Range(-1f, 1f);
        gunScript.enabled = false;
    }
}
