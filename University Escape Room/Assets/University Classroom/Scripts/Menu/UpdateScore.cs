using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    Player plyer;
    Text ScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        plyer = GameObject.Find("Player").GetComponent<Player>();
        ScoreTxt = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int score = plyer.getScore();
        ScoreTxt.text = score.ToString();
    }
}
