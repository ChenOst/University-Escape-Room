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
                    if (child.GetComponent<Text>() != null)
                    {
                        Text text = child.GetComponent<Text>();
                        text.text = myClue.getQuestion();
                    }
                }
                
            }
        }
    }
}
