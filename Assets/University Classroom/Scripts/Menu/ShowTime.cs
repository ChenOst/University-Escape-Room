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
    private string _secondStr = "00";
    private string _minuteStr = "00";

    [SerializeField]
    private Animator CameraAnimator;
    [SerializeField]
    private Animator FadeAnimator;


    // Start is called before the first frame update
    void Start()
    {
        _timeTxt = GameObject.Find("DigitalTimeText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!CameraAnimator.enabled && !FadeAnimator.enabled)
        {
            // Update the time evety second
            int seconds = (int)Time.time;
            if (seconds > _oldSeconds)
            {
                UpdateTime();
            }
            _oldSeconds = seconds;
        }
    }
    void UpdateTime()
    {
        _secondInt++;
        _secondStr = _secondInt.ToString();
        if (_secondStr.Length < 2)
        {
            _secondStr = "0" + _secondStr;
        }
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
        _timeTxt.text = _minuteStr + ":" + _secondStr;
    }
}
