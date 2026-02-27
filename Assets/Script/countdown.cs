using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
using TMPro;
using UnityEngine;                                                                                                      
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float StartTime;
    private float TimeLeft;

    public TMP_Text TimerText;
<<<<<<< Updated upstream
        void Start()
        {
        TimeLeft = StartTime;
        TimerText.gameObject.SetActive(true);
        }
    // Update is called once per frame
=======

    void Start()
    {
        TimeLeft = StartTime;

    }

>>>>>>> Stashed changes
    void Update()
    {
        if(TimeLeft > 0) 
        {
            //time tick down
            TimeLeft -= Time.deltaTime;
<<<<<<< Updated upstream
            TimerText.text = TimeLeft.ToString("0.00");
=======
                TimerText.text = TimeLeft.ToString("0.00");
>>>>>>> Stashed changes
        }
        else
        {
            //Timer Finished
<<<<<<< Updated upstream
            TimerText.gameObject.SetActive(true);
        }
    }
}
 //https://www.youtube.com/watch?v=T0atxxGoOlE
=======
        }

    }
    public void starttime() 
    {
        TimeLeft = StartTime;
    }
}
 //https://www.youtube.com/watch?v=T0atxxGoOlE
>>>>>>> Stashed changes
