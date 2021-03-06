﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowTime : MonoBehaviour
{
    [SerializeField]
    private GameObject _nextSceneCanvas;
    [SerializeField]
    private GameObject _playerWonText;

    private Text _timeTxt;
    private int _oldSeconds;
    private int _secondInt = 0;
    private int _minuteInt = 0;
    private string _secondStr = "00";
    private string _minuteStr = "00";

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
        _secondStr = _secondInt.ToString();
        if (_secondStr.Length < 2)
        {
            _secondStr = "0" + _secondStr;
        }
        // If the seconds become a minute
        if (_secondInt > 59)
        {
            _secondInt = 0;
            _secondStr = "00";
           _minuteInt++;
            _minuteStr = _minuteInt.ToString();
            if (_minuteStr.Length < 2)
            {
                _minuteStr = "0" + _minuteStr;
            }
        }
        _timeTxt.text = _minuteStr + ":" + _secondStr;

        if (_minuteInt == 30)
        {
            _nextSceneCanvas.SetActive(true);
            _playerWonText.SetActive(false);
            Debug.Log("Game Over: " + System.DateTime.Now);
            SceneManager.LoadScene("EndGameScene");
        }
    }

    public int RemainingTime()
    {
        int endTime = 30 * 60; // 30 minutes
        endTime = endTime - _secondInt - _minuteInt * 60;
        return endTime;
    }
}
