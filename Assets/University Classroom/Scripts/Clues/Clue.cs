using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    [SerializeField]
    private int ClueId;
    private bool ClueIsComplete = false;
    [SerializeField]
    private string Question = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getClueId()
    {
        return ClueId;
    }

    public void setClueIsComplete()
    {
        ClueIsComplete = true;
    }
    public string getQuestion()
    {
        return Question;
    }
}

