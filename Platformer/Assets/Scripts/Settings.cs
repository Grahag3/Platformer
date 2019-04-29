using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menu()
    {
        SceneManager.LoadScene("Intro");
        music.Stop();
    }

    public void back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Last_Scene"));
        if ((PlayerPrefs.GetString("Last_Scene") == "Menu"))
        {
            music.Stop();
        }
    }
}
