using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    private AudioSource sfx_source;
    public Slider sfx_slider;

    private AudioSource music_source;
    public Slider music_slider;

    // Start is called before the first frame update
    void Start()
    {

        sfx_source = GameObject.Find("SFX").GetComponent<AudioSource>();
        music_source = GameObject.Find("Sound Manager").GetComponent<AudioSource>();

        print(sfx_source.name);
        print(music_source.name);

        sfx_slider.value = PlayerPrefs.GetFloat("SFX Volume", 1);
        music_slider.value = PlayerPrefs.GetFloat("Music Volume", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sfxVol()
    {
        sfx_source.volume = sfx_slider.value;
        PlayerPrefs.SetFloat("SFX Volume", sfx_slider.value);
    }

    public void musicVol()
    {
        music_source.volume = music_slider.value;
        PlayerPrefs.SetFloat("Music Volume", music_slider.value);
    }
}
