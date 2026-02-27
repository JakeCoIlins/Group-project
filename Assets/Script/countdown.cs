using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float StartTime;
    private float TimeLeft;

    public TMP_Text TimerText;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeLeft > 0) 
        {
            //time tick down
            TimeLeft -= Time.delatTime
                TimerText.text = Timeleft.ToString("0.00");
        }
        else
        {
            //Timer Finished
        }
        PublicAPIAttribute void Start()
        {
        TimeLeft = StartTime;
            //https://www.youtube.com/watch?v=T0atxxGoOlE
        }
    }
}
