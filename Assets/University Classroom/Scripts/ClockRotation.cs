using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockRotation : MonoBehaviour
{
    GameObject minuteHand;
    GameObject hourHand;
    int oldSeconds;
    int secondInt =0;
    int minuteInt = 0;

    // Update is called once per frame
    void Start()
    {
        minuteHand = GameObject.Find("Minutes");
        hourHand = GameObject.Find("Hours");
        GetComponent<Renderer>().receiveShadows = enabled;

    }
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
        if (secondInt > 59)
        {
            secondInt = 0;
            minuteInt++;
        }
        //iTween.RotateTo(minuteHand, iTween.Hash("z", minuteInt * -1 * 6, "time", 1, "easetype", "easeOutElastic"));
        float hourDistance = (float)(minuteInt) / 60f;
        //iTween.RotateTo(hourHand, iTween.Hash("z", hourDistance * 360 / 12 * -1 , "time", 1, "easetype", "easeOutElastic"));
    }
}
