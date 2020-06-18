using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTime : MonoBehaviour
{
    [SerializeField]
    private GameObject _digitalClock;
    public void StartTime()
    {
        _digitalClock.GetComponent<ShowTime>().enabled = true;
    }
}
