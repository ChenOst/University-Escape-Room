using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotation : MonoBehaviour
{
    public GameObject minuteHand;
    public GameObject hourHand;
    int oldSeconds;
    int secondInt =0;
    int minuteInt = 0;

    // Update is called once per frame
    void Update()
    {
        int seconds = (int)Time.time;
        if (seconds > oldSeconds)
        {
            UpdateTime();
        }
        oldSeconds = seconds;
    }
    void UpdateTime()
    {
        secondInt++; 
        if (secondInt > 599)
        {
            secondInt = 0;
            minuteInt++;
        }
  
        iTween.RotateTo(minuteHand, iTween.Hash("z", secondInt * -1 / 1.666, "time", 1, "easetype", "easeOutElastic"));
        float hourDistance = (float)(secondInt) / 600f;
        iTween.RotateTo(hourHand, iTween.Hash("z", (minuteInt + hourDistance) * 360 / 12 * -1 , "time", 1, "easetype", "easeOutElastic"));
    }
}
