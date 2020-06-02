using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePanel : MonoBehaviour
{
    [SerializeField]
    GameObject []panelsChildrens;
    [SerializeField]
    GameObject MainCamera;
    [SerializeField]
    GameObject Player;

    public void Open()
    {
        foreach (GameObject child in panelsChildrens)
        {
            child.SetActive(true);
        }
       
        MainCamera.transform.GetComponent<MoveCamera>().enabled = false;
        Player.transform.GetComponent<MovePlayer>().enabled = false;
    }
    public void Close()
    {
        foreach (GameObject child in panelsChildrens)
        {
            child.SetActive(false);
        }
        MainCamera.transform.GetComponent<MoveCamera>().enabled = true;
        Player.transform.GetComponent<MovePlayer>().enabled = true;
    }
}
