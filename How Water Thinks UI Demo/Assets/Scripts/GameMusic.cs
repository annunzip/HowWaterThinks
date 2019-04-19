﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour {

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
    void Update()
    {
        string currSceneName = SceneManager.GetActiveScene().name;
        if (currSceneName != "Main Menu" && currSceneName != "Scene Selection" && currSceneName != "Settings Menu" && currSceneName != "Tutorial")
        {
            Destroy(this.gameObject);
        }
    }
}
