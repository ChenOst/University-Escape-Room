using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    private Text _timeTxt;
    private int _oldSeconds;
    private int _secondInt = 0;
    private int _minuteInt = 0;
    private int _hourInt = 0;
    private string _minuteStr = "00";
    private string _hourStr = "00";

    // Start is called before the first frame update
    void Start()
    {
        _timeTxt = GameObject.Find("DigitalTimeText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the time evety second
        int seconds = (int)Time.time;
        if (seconds > _oldSeconds)
        {
            UpdateTime();
        }
        _oldSeconds = seconds;
    }
    void UpdateTime()
    {
        _secondInt++;
        // If the seconds become a minute
        if (_secondInt > 59)
        {
            _secondInt = 0;
            _minuteInt++;
            _minuteStr = _minuteInt.ToString();
            if (_minuteStr.Length < 2)
            {
                _minuteStr = "0" + _minuteStr;
            }
        }
        // If the minutes become an hour
        if (_minuteInt > 59)
        {
            _minuteInt = 0;
            _hourInt++;
            _hourStr = _hourInt.ToString();
            if (_hourStr.Length < 2)
            {
                _hourStr = "0" + _hourStr;
            }
        }
        _timeTxt.text = _hourStr + ":" + _minuteStr;
    }
}
