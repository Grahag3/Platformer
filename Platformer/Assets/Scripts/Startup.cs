using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    private AudioSource music;

    private void Awake()
    {
        music = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        music.Play();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
