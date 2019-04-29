using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    //public Shot shot;
    private int current_score;

    public Text hs_1;
    public Text hs_2;
    public Text hs_3;
    public Text hs_4;
    public Text hs_5;

    private int hsi_1;
    private int hsi_2;
    private int hsi_3;
    private int hsi_4;
    private int hsi_5;

    // Start is called before the first frame update
    void Start()
    {
        current_score = PlayerPrefs.GetInt("Current Time");
        hsi_1 = PlayerPrefs.GetInt("HS 1");
        hsi_2 = PlayerPrefs.GetInt("HS 2");
        hsi_3 = PlayerPrefs.GetInt("HS 3");
        hsi_4 = PlayerPrefs.GetInt("HS 4");
        hsi_5 = PlayerPrefs.GetInt("HS 5");

        hs_1.text = "1." + hsi_1;
        hs_2.text = "2." + hsi_2;
        hs_3.text = "3." + hsi_3;
        hs_4.text = "4." + hsi_4;
        hs_5.text = "5." + hsi_5;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
