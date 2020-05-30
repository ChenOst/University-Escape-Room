using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducationPanel : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject MainCamera;
    [SerializeField]
    GameObject Player;

    public void Open()
    {
        panel.SetActive(true);
        MainCamera.transform.GetComponent<MoveCamera>().enabled = false;
        Player.transform.GetComponent<MovePlayer>().enabled = false;
    }
    public void Close()
    {
        panel.SetActive(false);
        MainCamera.transform.GetComponent<MoveCamera>().enabled = true;
        Player.transform.GetComponent<MovePlayer>().enabled = true;
    }
}
