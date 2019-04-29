using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreData : MonoBehaviour
{

    private int current_score;

    private int hsi_1;
    private int hsi_2;
    private int hsi_3;
    private int hsi_4;
    private int hsi_5;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("Last_Scene") == "Gameplay")
        {
            Debug.Log(PlayerPrefs.GetInt("Current Time"));
            current_score = PlayerPrefs.GetInt("Current Time");
            hsi_1 = PlayerPrefs.GetInt("HS 1", 100);
            hsi_2 = PlayerPrefs.GetInt("HS 2", 100);
            hsi_3 = PlayerPrefs.GetInt("HS 3", 100);
            hsi_4 = PlayerPrefs.GetInt("HS 4", 100);
            hsi_5 = PlayerPrefs.GetInt("HS 5", 100);
        }
       
    }

    // Update is called once per frame
    void Update()
    {

        if (current_score < hsi_1)
        {


            PlayerPrefs.SetInt("HS 1", current_score);
            PlayerPrefs.SetInt("HS 2", hsi_1);
            PlayerPrefs.SetInt("HS 3", hsi_2);
            PlayerPrefs.SetInt("HS 4", hsi_3);
            PlayerPrefs.SetInt("HS 5", hsi_4);
        }
        else if (current_score < hsi_2 && current_score > hsi_1)
        {

            PlayerPrefs.SetInt("HS 2", current_score);
            PlayerPrefs.SetInt("HS 3", hsi_2);
            PlayerPrefs.SetInt("HS 4", hsi_3);
            PlayerPrefs.SetInt("HS 5", hsi_4);

        }
        else if (current_score < hsi_3 && current_score > hsi_2)
        {




            PlayerPrefs.SetInt("HS 3", current_score);
            PlayerPrefs.SetInt("HS 4", hsi_3);
            PlayerPrefs.SetInt("HS 5", hsi_4);

        }
        else if (current_score < hsi_4 && current_score > hsi_3)
        {


            PlayerPrefs.SetInt("HS 4", current_score);
            PlayerPrefs.SetInt("HS 5", hsi_4);

        }
        else if (current_score < hsi_5 && current_score > hsi_4)
        {

            PlayerPrefs.SetInt("HS 5", current_score);

        }



        PlayerPrefs.SetInt("Current Time", 0);
    }
}
