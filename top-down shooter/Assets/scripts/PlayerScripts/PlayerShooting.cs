using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] float playerBulletSpeed = 4f;
    [SerializeField] GameObject playerBullet;
    [SerializeField] GameObject FunGun;
    bool shotgunAquired = false;

    // update github comment :3
    void Start()
    {
        
    }

    void OnFire()
    {
        if (shotgunAquired == true)
        {
            for (int i = 30; i > -60; i -= 30)
            {
                float angle = 100 - i;
                Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, angle));
                GameObject bullet = Instantiate(playerBullet, FunGun.transform.position, rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * playerBulletSpeed, ForceMode2D.Impulse);
            }
        }
        else
        {
            GameObject bullet = Instantiate(playerBullet, FunGun.transform.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * playerBulletSpeed, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Upgrade"))
        {
            shotgunAquired = true;
        }
    }
}
