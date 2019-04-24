using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownReaction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void ChangeResolution()
    {
        //Dropdown resDD = GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>();
        Dropdown resDD = GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>();
        int newWidth = 1280, newHeight = 720;
        if (resDD.value == 0) { newWidth = 1280; newHeight = 720; Globals.windowSize = 0; } else 
        if (resDD.value == 1) { newWidth = 1360; newHeight = 768; Globals.windowSize = 1; } else
        if (resDD.value == 2) { newWidth = 1366; newHeight = 768; Globals.windowSize = 2; } else
        if (resDD.value == 3) { newWidth = 1600; newHeight = 900; Globals.windowSize = 3; } else
        if (resDD.value == 4) { newWidth = 1920; newHeight = 1080; Globals.windowSize = 4; }

        Screen.SetResolution(newWidth, newHeight, GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
