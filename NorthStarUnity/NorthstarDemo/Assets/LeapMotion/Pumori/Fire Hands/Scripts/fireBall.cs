using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{

    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }


   
}

