using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;                                                                                                      
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class countdown : MonoBehaviour
{
    public float StartTime;
    private float TimeLeft;

    public TMP_Text TimerText;

        void Start()
        {
        TimeLeft = StartTime;
        TimerText.gameObject.SetActive(true);
        }

    void Update()
    {
        if(TimeLeft > 0) 
        {
            //time tick down
            TimeLeft -= Time.deltaTime;

            TimerText.text = TimeLeft.ToString("0.00");

                TimerText.text = TimeLeft.ToString("0.00");

        }
        else
        {
            //Timer Finished

            TimerText.gameObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
 //https://www.youtube.com/watch?v=T0atxxGoOlE
    public void starttime() 
    {
        TimeLeft = StartTime;
    }
}
 //https://www.youtube.com/watch?v=T0atxxGoOlE

