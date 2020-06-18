using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour {

    public BaseSafeHandler safeHandler;
    public bool isOpen = false;

    Animator doorAnimator;

    [SerializeField]
    Player player;
    [SerializeField]
    GameObject[] endGameMessage;
    [SerializeField]
    Light safeLight;

    // Use this for initialization
    void Start () {
        doorAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (isOpen)
        {
            CloseDoor();
        }
        else {
            if (safeHandler == null || !safeHandler.IsLocked()) { 
                OpenDoor();
            }
        }
    }

    public void OpenDoor() {
        doorAnimator.Play("OpenDoor", -1, 0f);
        isOpen = true;
        safeLight.enabled = true;
        player.SetcanOpenDoor();
        foreach(GameObject child in endGameMessage)
        {
            child.SetActive(true);
        }
    }

    public void CloseDoor()
    {
        doorAnimator.Play("CloseDoor",-1,0f);
        isOpen = false;
        safeLight.enabled = false;
    }
}
