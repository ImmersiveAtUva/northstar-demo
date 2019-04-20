using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeAndDate : MonoBehaviour
{

    public TextMeshPro currentTime;
    public TextMeshPro currentDate;


    
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime.text = System.DateTime.Now.ToString("hh:mm tt");
        currentDate.text = System.DateTime.Today.DayOfWeek.ToString(); 

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
