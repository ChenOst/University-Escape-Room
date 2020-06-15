using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private Player _plyer;
    private Text _scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        _plyer = GameObject.Find("Player").GetComponent<Player>();
        _scoreTxt = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the score according to the score earned by the player
        int score = _plyer.getScore();
        _scoreTxt.text = score.ToString();
    }
}
