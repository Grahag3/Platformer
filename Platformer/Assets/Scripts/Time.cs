using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour
{

    public static int time = 0;
    private int initial_time = 0;
    public Text time_ui;

    private void Awake()
    {
        time = initial_time;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Count", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Count()
    {
        time += 1;
        PlayerPrefs.SetInt("Current Time", time);
        time_ui.text = "Time: " + time.ToString();

   

    }
}
