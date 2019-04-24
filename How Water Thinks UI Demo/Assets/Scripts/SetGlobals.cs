using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGlobals : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (!Globals.firstLaunch)
        {
            Globals.volume = 0.5f;
            Globals.colorblindOn = false;

            if (Screen.width == 1280) Globals.windowSize = 0;
            else
            if (Screen.width == 1360) Globals.windowSize = 1;
            else
            if (Screen.width == 1366) Globals.windowSize = 2;
            else
            if (Screen.width == 1600) Globals.windowSize = 3;
            else
            if (Screen.width == 1920) Globals.windowSize = 4;
            else Globals.windowSize = 0;

            if (Screen.fullScreen) Globals.fullscreenOn = true;
            else Globals.fullscreenOn = false;

            (Resources.Load("Prefabs/sodiumAtom") as GameObject).GetComponent<Renderer>().material = Resources.Load("Materials/sodiumAtom") as Material;
        }
    }
}
