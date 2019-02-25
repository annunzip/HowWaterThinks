using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class sliderReaction : MonoBehaviour {

    //public Slider ionSlider;

    // Use this for initialization
    void Start () {

}

    public void HandleNaSliderChange(Slider naSlider)
    {
        //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfChlorineAtoms = (int)ionSlider.value;
        //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfSodiumAtoms = (int)ionSlider.value;
        int numAtoms = GameObject.FindGameObjectsWithTag("SodiumAtom").Length;

        //Debug.Log("numAtoms = " + numAtoms);
        //Debug.Log("ionSlider.value = " + (int)(ionSlider.value));
        if (numAtoms < (int)(naSlider.value)){
            while (numAtoms < (int)(naSlider.value)){
                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, (int)Math.Floor(naSlider.value - numAtoms), 0, 0);
                numAtoms++;
            }

        } 
        else if (numAtoms > (int)(naSlider.value)){
            int destroyNum  = numAtoms-(int)(naSlider.value);
            for(int i=0; i < destroyNum; i++){
                Destroy(GameObject.FindGameObjectsWithTag("SodiumAtom")[i]);
                numAtoms--;
            }
        }
    }

    public void HandleClSliderChange(Slider clSlider)
    {
        int numAtoms = GameObject.FindGameObjectsWithTag("ChlorineAtom").Length;

        if (numAtoms < (int)(clSlider.value))
        {
            while (numAtoms < (int)(clSlider.value))
            {
                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, (int)Math.Floor(clSlider.value - numAtoms), 0);
                numAtoms++;
            }

        }
        else if (numAtoms > (int)(clSlider.value))
        {
            int destroyNum = numAtoms - (int)(clSlider.value);
            for (int i = 0; i < destroyNum; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("ChlorineAtom")[i]);
                numAtoms--;
            }
        }
    }

    public void HandleKSliderChange(Slider kSlider)
    {
        int numAtoms = GameObject.FindGameObjectsWithTag("PotassiumAtom").Length;

        if (numAtoms < (int)(kSlider.value))
        {
            while (numAtoms < (int)(kSlider.value))
            {
                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, (int)Math.Floor(kSlider.value - numAtoms));
                numAtoms++;
            }

        }
        else if (numAtoms > (int)(kSlider.value))
        {
            int destroyNum = numAtoms - (int)(kSlider.value);
            for (int i = 0; i < destroyNum; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("PotassiumAtom")[i]);
                numAtoms--;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log("Test2");
    }
} 
