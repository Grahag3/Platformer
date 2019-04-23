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
        
    }

    public void retry()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void quit()
    {
        Application.Quit();
    }
}
