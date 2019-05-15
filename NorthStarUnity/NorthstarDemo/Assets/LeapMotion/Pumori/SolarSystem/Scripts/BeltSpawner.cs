﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject cubePrefab;
    public int cubeDensity; //how many asteroids in our belt
    public int seed;
    public float innerRadius;
    public float outRadius;
    public float height;
    public bool rotatingClockwise;

    [Header("Asteroid Settings")]
    public float minOrbitSpeed;
    public float maxOrbitSpeed;
    public float minRotationSpeed;
    public float maxRoationSpeed;


    private Vector3 localPosition;
    private Vector3 worldOffset;
    private Vector3 worldPosition;

    private float randomRadius;
    private float randomRadian;
    private float x;
    private float y;
    private float z;


    private void Start()
    {
        Random.InitState(seed);

        for (int i = 0; i < cubeDensity; i++)
        {
            do
            {

                randomRadius = Random.Range(innerRadius, outRadius);

                randomRadian = Random.Range(0, (2 * Mathf.PI));

                y = Random.Range(-(height / 2), (height / 2));
                x = randomRadius * Mathf.Cos(randomRadian);
                z = randomRadius * Mathf.Sin(randomRadian);
            }
            while (float.IsNaN(z) && float.IsNaN(x));

            localPosition = new Vector3(x,y,z);
            worldOffset = transform.rotation * localPosition;
            worldPosition = transform.position + worldOffset;


            GameObject _asteroid = Instantiate(cubePrefab, worldPosition, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            _asteroid.AddComponent<BeltObject>().SetupBeltObject(Random.Range(minOrbitSpeed, maxOrbitSpeed), Random.Range(minRotationSpeed, maxRoationSpeed), gameObject, rotatingClockwise); 
            _asteroid.transform.SetParent(transform); 

        }
    }

}
