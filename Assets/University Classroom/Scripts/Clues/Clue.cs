using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    [SerializeField]
    private int _clueId;
    private bool _clueIsComplete = false;
    [SerializeField]
    private string _answer;
    [SerializeField]
    private string _type;
    [SerializeField]
    private GameObject[] _nextClue;
    [SerializeField]
    private int _score;

    public int getClueId()
    {
        return _clueId;
    }
    public void setClueIsComplete()
    {
        _clueIsComplete = true;
        foreach(GameObject clue in _nextClue)
        {
            clue.GetComponent<Collider>().enabled = true;
        }
    }

    public bool getClueIsComplete()
    {
        return _clueIsComplete;
    }

    public string getAnswer()
    {
        return _answer;
    }
    public string getType()
    {
        return _type;
    }
    public int getScore()
    {
        return _score;
    }
}

