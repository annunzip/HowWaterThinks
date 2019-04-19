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
    }

    public void DisableSettingsOverlay(GameObject settingsOverlay)
    {
        //simulationCanvas.gameObject.SetActive(true);
        settingsOverlay.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
