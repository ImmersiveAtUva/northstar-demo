using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject projectile;
    //public Transform spawn; 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }


    public void FireMissle()
    {
        GameObject fireBall = Instantiate(projectile, transform.position, transform.rotation * Quaternion.Euler(0, 0, 90)) as GameObject;
       
        Rigidbody rb = fireBall.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 5;


    }

    //public void missileFire()
    //{
    //    Rigidbody fireBall;
    //    fireBall = Instantiate(projectile, spawn.position, spawn.rotation) as Rigidbody;
    //    fireBall.AddForce(spawn.forward * 50);
    //}



}

   
