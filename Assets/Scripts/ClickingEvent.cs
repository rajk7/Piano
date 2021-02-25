using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingEvent : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
    public void AboutUs()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
