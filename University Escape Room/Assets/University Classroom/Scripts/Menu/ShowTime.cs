using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    Text timeTxt;
    int oldSeconds;
    int secondInt = 0;
    int minuteInt = 0;
    int hourInt = 0;
    string minuteStr = "00";
    string hourStr = "00";
    // Start is called before the first frame update
    void Start()
    {
        timeTxt = GameObject.Find("DigitalTimeText").GetComponent<Text>();
    }

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
        if (secondInt > 59)
        {
            secondInt = 0;
            minuteInt++;
            minuteStr = minuteInt.ToString();
            if (minuteStr.Length < 2)
            {
                minuteStr = "0" + minuteStr;
            }
        }
        if (minuteInt > 59)
        {
            minuteInt = 0;
            hourInt++;
            hourStr = hourInt.ToString();
            if (hourStr.Length < 2)
            {
                hourStr = "0" + hourStr;
            }
        }
        timeTxt.text = hourStr + ":" + minuteStr;
    }
}
