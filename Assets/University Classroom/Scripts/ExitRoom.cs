using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitRoom : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    private GameObject ExitPanel;
    [SerializeField]
    private GameObject _nextSceneCanvas;
    [SerializeField]
    private GameObject _gameOverText;
    [SerializeField]
    private GameObject _playerWonText;
    [SerializeField]
    private GameObject _time;
    private bool canActive;
    private bool nextToDoor=false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && canActive)
        {
            nextToDoor = true;
            ExitPanel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && canActive)
        {
            nextToDoor = false;
            ExitPanel.SetActive(false);
        }
    }
    void Update()
    {
        canActive = _player.GetcanOpenDoor();
        if (nextToDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                int morePoints = _player.getScore() + _time.GetComponent<ShowTime>().RemainingTime();
                _player.setScore(morePoints);
                _mainCamera.transform.GetComponent<MoveCamera>().enabled = false;
                _player.transform.GetComponent<MovePlayer>().enabled = false;
                _nextSceneCanvas.SetActive(true);
                _playerWonText.GetComponent<Text>().text = _playerWonText.GetComponent<Text>().text + _player.getScore();
                _gameOverText.SetActive(false);
                Debug.Log("End game: " + System.DateTime.Now);
                SceneManager.LoadScene("EndGameScene");
            }
        }
    }
}
