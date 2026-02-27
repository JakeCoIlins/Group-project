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
        void Start()
        {
        TimeLeft = StartTime;
           
        }
    // Update is called once per frame
    void Update()
    {
        if(TimeLeft > 0) 
        {
            //time tick down
            TimeLeft -= Time.deltaTime;
                TimerText.text = TimeLeft.ToString("0.00");
        }
        else
        {
            //Timer Finished
        }

    }
}
 //https://www.youtube.com/watch?v=T0atxxGoOlE