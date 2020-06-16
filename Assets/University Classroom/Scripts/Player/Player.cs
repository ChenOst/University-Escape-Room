using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int score = 0;
    bool canOpenDoor = false;
    public int getScore()
    {
        return score;
    }
    public int setScore(int points)
    {
        return score += points;
    }
    public void SetcanOpenDoor()
    {
        canOpenDoor = true;
    }
    public bool GetcanOpenDoor()
    {
        return canOpenDoor;
    }
}
