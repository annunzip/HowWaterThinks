using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour {

    public AudioClip menuMusic, levelMusic;
    //static bool AudioBegin = false;
    void Awake()
    {
        GameObject musicPlayer = GameObject.Find("Music");
        if (musicPlayer == null)
        {
            musicPlayer = this.gameObject;
            musicPlayer.name = "Music";
            DontDestroyOnLoad(musicPlayer);
            GetComponent<AudioSource>().Play();
            /*AudioBegin = true;
            if (!AudioBegin)
            {
                
            }*/
        } else
        {
            if (this.gameObject.name != "Music")
            {
                Destroy(this.gameObject);
            }
        }
    }

    void PlayMenuMusic()
    {
        GetComponent<AudioSource>().clip = menuMusic;
        GetComponent<AudioSource>().Play();
    }

    void PlayLevelMusic()
    {
        GetComponent<AudioSource>().clip = levelMusic;
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        string currSceneName = SceneManager.GetActiveScene().name;
        if (currSceneName != "Main Menu" && currSceneName != "Scene Selection" && currSceneName != "Settings Menu" && currSceneName != "Tutorial" && currSceneName != "About Scene")
        {
            //Destroy(this.gameObject);
            if (GetComponent<AudioSource>().clip == menuMusic)
            {
                PlayLevelMusic();
            }
        } else
        {
            if (GetComponent<AudioSource>().clip == levelMusic)
            {
                PlayMenuMusic();
            }
        }
    }
}
