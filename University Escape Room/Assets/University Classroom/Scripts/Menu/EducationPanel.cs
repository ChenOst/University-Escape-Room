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

    public void Open()
    {
        panel.SetActive(true);
        MainCamera.transform.GetComponent<MoveCamera>().enabled = false;
    }
    public void Close()
    {
        panel.SetActive(false);
        MainCamera.transform.GetComponent<MoveCamera>().enabled = true;
    }
}
