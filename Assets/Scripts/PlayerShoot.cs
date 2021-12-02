using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    GameObject _playerGun;
    GameObject _bulletPool;
    BulletController[] _playerBullets;

    GameObject _endOfGunBarrel;

    public float _shootingDelay = 1.5f;
    float _bulletFired = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _endOfGunBarrel = GameObject.FindGameObjectWithTag("BulletSpawn");
        _playerGun = GameObject.FindGameObjectWithTag("PlayerWeapon");

        _bulletPool = GameObject.FindGameObjectWithTag("BulletPool");
        _playerBullets = _bulletPool.GetComponentsInChildren<BulletController>();
        foreach(BulletController bullet in _playerBullets)
        {
            bullet.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_bulletFired <= 0.0f)
                foreach(BulletController bullet in _playerBullets)
                {
                    if(!bullet.gameObject.activeInHierarchy)
                    {
                        bullet.gameObject.SetActive(true);
                        bullet.transform.position = _endOfGunBarrel.transform.position;

                        bullet.transform.forward = new Vector3(gameObject.transform.forward.x, bullet.transform.forward.y, gameObject.transform.forward.z);

                        _bulletFired += _shootingDelay;
                        break;
                    }
                }
        }
        _bulletFired -= Time.deltaTime;
    }
}
