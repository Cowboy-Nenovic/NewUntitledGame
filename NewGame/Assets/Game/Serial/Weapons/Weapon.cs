using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update

      [Header ("Refrences")]
     [SerializeField] public WeaponData weaponData;
     [SerializeField] private Transform Muzzle;
     public GameObject Bullet;
    float TimeSinceLastShot; 
     
    private void Start()
    {
        AimShoot.ShootInput += CheckCanShoot;
        AimShoot.ReloadInput += StartReload;
        
    }

    private void Update(){
      TimeSinceLastShot += Time.deltaTime;

    }
    public void StartReload()
    {
      if(!weaponData.reloadState){
        StartCoroutine(Relaod());
      }

    }
  private IEnumerator Relaod(){
    weaponData.reloadState = true;

    yield return new WaitForSeconds(weaponData.reloadSpeed);
    weaponData.currentAmmo = weaponData.magazineSize;

    weaponData.reloadState = false;
  }
  private bool CanShoot() => !weaponData.reloadState && TimeSinceLastShot > 1f / (weaponData.fireRate / 60f);

  public void CheckCanShoot()
  {

    if (weaponData.currentAmmo > 0 && CanShoot()) 
      {
        weaponData.currentAmmo--;
        TimeSinceLastShot = 0;
        ShootGun();
      
    }
  }
  private void ShootGun(){
  Muzzle.localRotation = Quaternion.Euler(new Vector3(Muzzle.localRotation.x, Muzzle.localRotation.y, UnityEngine.Random.Range(-weaponData.recoil,weaponData.recoil)));
  GameObject newBullet = Instantiate(Bullet, Muzzle.position, Quaternion.identity);
  newBullet.GetComponent<BulletBehaviour>().force =10;
  }

}
