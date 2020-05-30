using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Starting new game: " + System.DateTime.Now);
        SceneManager.LoadScene("GameScene");
    }
    public void ExitGame()
    {
        Debug.Log("Exit the game: " + System.DateTime.Now);
        Application.Quit();
    }
}
