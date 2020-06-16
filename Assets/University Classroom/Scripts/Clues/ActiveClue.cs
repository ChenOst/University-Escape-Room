using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveClue : MonoBehaviour
{
    private bool canActive = false;
    [SerializeField]
    private GameObject EPanel;
    [SerializeField]
    GameObject[] panelsChildrens;
    [SerializeField]
    private Clue myClue;
    [SerializeField]
    GameObject MainCamera;
    [SerializeField]
    GameObject Player;
    private Clue _thisClue;
    [SerializeField]
    private Text input;

    // Start is called before the first frame update
    void Start()
    {
        _thisClue = gameObject.GetComponent<Clue>();
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
        }
    }
    void Update()
    {
        if (canActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                MainCamera.transform.GetComponent<MoveCamera>().enabled = false;
                Player.transform.GetComponent<MovePlayer>().enabled = false;
                foreach (GameObject child in panelsChildrens)
                {
                    child.SetActive(true);
                }
                if (_thisClue.getType() == "A")
                {
                    _thisClue.setClueIsComplete();
                }
            }
        }
    }
}
