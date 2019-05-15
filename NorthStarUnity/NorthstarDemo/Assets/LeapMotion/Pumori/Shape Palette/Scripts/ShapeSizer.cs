using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeBigger()
    {
        gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);

    }

    public void makeSmall()
    {
        gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f); 

    }

    public void cubeBig()
    {
        gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
    }

    public void cubeSmall()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    public void PyramidBig()
    {
        gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }

    public void PyramidSmall()
    {
        gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

    }

    public void SphereBig()
    {
        gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }

    public void SphereSmall()
    {
        gameObject.transform.localScale = new Vector3(0.12f, 0.12f, 0.12f);
    }

    public void TorusBig()
    {
        gameObject.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
    }

    public void TorusSmall()
    {
        gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    public void CylBig()
    {
        gameObject.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
    }

    public void CylSmall()
    {
        gameObject.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
    }

}
