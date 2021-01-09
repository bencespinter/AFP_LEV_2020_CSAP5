using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
    public bool isPause = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                Resume();
            }
            else Pause();
        }

    }
    public void StartButton(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
    void OnMouseUp()
    {
        if (isQuit)
        {
            Application.Quit();
        }
        if (isStart)
        {
            SceneManager.LoadScene("2nd_fields");
            //Application.LoadLevel(Application.loadedLevel);
            //Application.LoadLevel(1);			
            //renderer.material.color = Color.cyan;
        }
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }
    //pause gombot is implemetálni kell!
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}