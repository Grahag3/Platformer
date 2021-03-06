﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Gameplay");
        }
    }

    public void retry()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void settings()
    {
        PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Settings");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void scores()
    {
        PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("High Scores");
    }
}
