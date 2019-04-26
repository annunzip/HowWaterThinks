using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ToggleOverlay : MonoBehaviour {

    //public Canvas simulationCanvas;

    // Use this for initialization
    void Start () {
		
	}

    public void DisplayHelpOverlay(GameObject tutorialOverlay)
    {
       // simulationCanvas.gameObject.SetActive(false);
        tutorialOverlay.gameObject.SetActive(true);
    }

    public void DisableHelpOverlay(GameObject tutorialOverlay)
    {
       // simulationCanvas.gameObject.SetActive(true);
        tutorialOverlay.gameObject.SetActive(false);
    }

    public void DisplaySettingsOverlay(GameObject settingsOverlay)
    {
        //simulationCanvas.gameObject.SetActive(false);
        settingsOverlay.gameObject.SetActive(true);
        if (GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 0) GameObject.FindGameObjectWithTag("VolumeSlider").GetComponent<Slider>().value = Globals.volume;
        if (GameObject.FindGameObjectsWithTag("ColorblindToggle").Length > 0) GameObject.FindGameObjectWithTag("ColorblindToggle").GetComponent<Toggle>().isOn = Globals.colorblindOn;
        if (GameObject.FindGameObjectsWithTag("Resolution").Length > 0) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = Globals.windowSize;
        if (GameObject.FindGameObjectsWithTag("Fullscreen").Length > 0) GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn = Globals.fullscreenOn;
    }

    public void DisableSettingsOverlay(GameObject settingsOverlay)
    {
        //simulationCanvas.gameObject.SetActive(true);
        settingsOverlay.gameObject.SetActive(false);
        if (GameObject.FindGameObjectsWithTag("VolumeSlider").Length > 0) GameObject.FindGameObjectWithTag("VolumeSlider").GetComponent<Slider>().value = Globals.volume;
        if (GameObject.FindGameObjectsWithTag("ColorblindToggle").Length > 0) GameObject.FindGameObjectWithTag("ColorblindToggle").GetComponent<Toggle>().isOn = Globals.colorblindOn;
        if (GameObject.FindGameObjectsWithTag("Resolution").Length > 0) GameObject.FindGameObjectWithTag("Resolution").GetComponent<Dropdown>().value = Globals.windowSize;
        if (GameObject.FindGameObjectsWithTag("Fullscreen").Length > 0) GameObject.FindGameObjectWithTag("Fullscreen").GetComponent<Toggle>().isOn = Globals.fullscreenOn;
    }



    // Update is called once per frame
    void Update () {
		
	}
}
