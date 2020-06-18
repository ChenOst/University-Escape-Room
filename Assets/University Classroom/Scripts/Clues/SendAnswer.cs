using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendAnswer : MonoBehaviour
{
    [SerializeField]
    private Text ansText;
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    private Clue _thisClue;
    [Tooltip("All the objects that needs to be Inactive")]
    [SerializeField]
    private GameObject[] panelsChildrens;

    [SerializeField]
    private GameObject textPrefab;
    [SerializeField]
    private GameObject message;

    public void getAnswer()
    {
        string ans = ansText.text;
        Debug.Log(ans);
        if (ans == _thisClue.getAnswer())
        {
            _thisClue.setClueIsComplete();
            Player playerScore = Player.GetComponent<Player>();
            playerScore.setScore(_thisClue.getScore());

            foreach (GameObject child in panelsChildrens)
            {
                child.SetActive(false);
            }
            // If object is not active the player can move and can move the camera
            _mainCamera.transform.GetComponent<MoveCamera>().enabled = true;
            Player.transform.GetComponent<MovePlayer>().enabled = true;
            _thisClue.GetComponent<Collider>().enabled = false;
            _thisClue.GetComponent<ActiveClue>().enabled = false;
            ShowText();
        }
    }

    public void ShowText()
    {
        Instantiate(textPrefab, message.transform.position, Quaternion.identity, message.transform);
    }
}
