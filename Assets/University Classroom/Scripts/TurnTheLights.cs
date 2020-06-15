using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnTheLights : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;
    private GameObject[] _lights;

    private bool _lightsOn = false;
    private bool _canActive = false;

    // Start is called before the first frame update
    void Start()
    {
        _lights = GameObject.FindGameObjectsWithTag("Light");
        if (_lights != null)
        {
            foreach (GameObject light in _lights)
            {
                light.SetActive(_lightsOn);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _canActive = true;
            _panel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _canActive = false;
            _panel.SetActive(false);
        }
    }
    void Update()
    {
        // If the player is next to the Switch he can active the lights
        if (_canActive)
        {
            // The lights staus change when the player clicks E keys
            if (Input.GetKeyDown(KeyCode.E))
            {
                _lightsOn = !_lightsOn;
                // Change all the lights in the room
                foreach (GameObject light in _lights)
                {
                    light.SetActive(_lightsOn);
                }
            }
        }
    }
}
