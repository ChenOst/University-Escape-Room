using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClue : MonoBehaviour
{
    [SerializeField]
    private Clue _nextClue;

    // Update is called once per frame
    void Update()
    {
        if (_nextClue.getClueIsComplete())
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<ActiveClue>().enabled = false;
        }
    }
}
