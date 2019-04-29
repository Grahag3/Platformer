using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static new AudioSource audio;
    public static AudioClip jump;
    public static AudioClip press;
    public static AudioClip death;

    public AudioSource music;

    public static float sfxvol;
    public static float musicvol;

    private void Awake()
    {
        sfxvol = PlayerPrefs.GetFloat("SFX Volume", 20);
        musicvol = PlayerPrefs.GetFloat("Music Volume", 20);

    }
    private void Start()
    {
        jump = Resources.Load<AudioClip>("Jump");
        press = Resources.Load<AudioClip>("Press");
        death = Resources.Load<AudioClip>("Death");

        music.volume = musicvol;

        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void play_sound(string clip)
    {
        if (clip == "Jump")
        {
            audio.PlayOneShot(jump, sfxvol);
        }
        if (clip == "Press")
        {
            audio.PlayOneShot(press, sfxvol);
        }
        if (clip == "Death")
        {
            audio.PlayOneShot(death, sfxvol);
        }
    }
}
