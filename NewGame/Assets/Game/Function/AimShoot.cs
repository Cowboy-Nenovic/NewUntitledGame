using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour
{

    private Camera mainCam;
    private Vector3 mousePos;
    public static Action ShootInput;
    public static Action ReloadInput;




    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotateZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotateZ);

        


        if (Input.GetMouseButton(0))
        {
            ShootInput?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadInput?.Invoke();
        }
    }

}
