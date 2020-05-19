using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnTheLights : MonoBehaviour
{
    private bool lightsOn = false;
    private bool canActive = false;
    private GameObject[] _lights;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        _lights = GameObject.FindGameObjectsWithTag("Light");
        if (_lights != null)
        {
            foreach (GameObject light in _lights)
            {
                light.SetActive(lightsOn);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canActive = true;
            panel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canActive = false;
            panel.SetActive(false);
        }
    }
    void Update()
    {
        if (canActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                lightsOn = !lightsOn;
                foreach (GameObject light in _lights)
                {
                    light.SetActive(lightsOn);
                }
            }
        }
    }
}
