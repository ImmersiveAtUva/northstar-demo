﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HovSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LargeOnHov()
    {
        gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

    }

    public void BackToReg()
    {
        gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, -0.2f);

    }

    
}