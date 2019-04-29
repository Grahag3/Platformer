using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Last_Scene"));
        PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);

    }
}
