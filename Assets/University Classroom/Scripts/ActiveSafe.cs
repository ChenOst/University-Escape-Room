using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSafe : MonoBehaviour
{

    private bool canActive = false;
    [SerializeField]
    private GameObject EPanel;
    [SerializeField]
    private Camera FpsCam, TpsCam;
    bool fpsCam = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canActive = true;
            EPanel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canActive = false;
            EPanel.SetActive(false);
            fpsCam = !fpsCam;
            FpsCam.enabled = fpsCam;
            TpsCam.enabled = !fpsCam;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                fpsCam = !fpsCam;
                FpsCam.enabled = fpsCam;
                TpsCam.enabled = !fpsCam;
                EPanel.SetActive(false);
            }
        }
    }
}
