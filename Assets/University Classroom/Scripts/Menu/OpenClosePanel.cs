using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosePanel : MonoBehaviour
{
    [Tooltip("All the objects that needs to be Active/Inactive")]
    [SerializeField]
    private GameObject[]panelsChildrens;
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    private GameObject _player;

    // Set Active 
    public void Open()
    {
        foreach (GameObject child in panelsChildrens)
        {
            child.SetActive(true);
        }
        // If object is active the player can't move and can't move the camera
        _mainCamera.transform.GetComponent<MoveCamera>().enabled = false;
        _player.transform.GetComponent<MovePlayer>().enabled = false;
    }
    public void Close()
    {
        foreach (GameObject child in panelsChildrens)
        {
            child.SetActive(false);
        }
        // If object is not active the player can move and can move the camera
        _mainCamera.transform.GetComponent<MoveCamera>().enabled = true;
        _player.transform.GetComponent<MovePlayer>().enabled = true;
    }
}
