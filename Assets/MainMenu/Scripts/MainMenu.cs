using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    bool canShow = false;
    [SerializeField]
    GameObject Credits;
    public void StartGame()
    {
        Debug.Log("Starting new game: " + System.DateTime.Now);
        SceneManager.LoadScene("GameScene");
    }
    public void ExitGame()
    {
        Debug.Log("Exit the game: " + System.DateTime.Now);
        Application.ExternalEval("window.open(\"https://github.com/ChenOst/University-Escape-Room\")");
        Application.OpenURL("about:blank");
    }
    public void showCredits()
    {
        canShow = !canShow;
        Credits.SetActive(canShow);
    }
}
