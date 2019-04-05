using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class sliderReaction : MonoBehaviour {

    //public Slider ionSlider;

    // Use this for initialization
    void Start () {

}

    public void HandleNaSliderChange(Slider naSlider)
    {
        if (GameObject.FindGameObjectsWithTag("NumClIons") != null && GameObject.FindGameObjectsWithTag("NumNaIons") != null)
            if (GameObject.FindGameObjectsWithTag("NumClIons").Length > 0 && GameObject.FindGameObjectsWithTag("NumNaIons").Length > 0 && 
            GameObject.FindGameObjectsWithTag("NumKIons").Length > 0) 
            GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value + 
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value;

        if (GameObject.FindGameObjectWithTag("naToggle").GetComponent<Toggle>().isOn)
        {
            //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfChlorineAtoms = (int)ionSlider.value;
            //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfSodiumAtoms = (int)ionSlider.value;
            int numAtoms = GameObject.FindGameObjectsWithTag("SodiumAtom").Length;

            //Debug.Log("numAtoms = " + numAtoms);
            //Debug.Log("ionSlider.value = " + (int)(ionSlider.value));
            if (numAtoms < (int)(naSlider.value))
            {
                Debug.Log(numAtoms);
                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, (int)Math.Floor(naSlider.value - numAtoms), 0, 0);
                numAtoms++;


            }
            else if (numAtoms > (int)(naSlider.value))
            {
                int destroyNum = numAtoms - (int)(naSlider.value);
                for (int i = 0; i < destroyNum; i++)
                {
                    Destroy(GameObject.FindGameObjectsWithTag("SodiumAtom")[i]);
                    numAtoms--;
                }
            }
        }
    }

    public void HandleClSliderChange(Slider clSlider)
    {
        if (GameObject.FindGameObjectsWithTag("NumClIons").Length > 0 && GameObject.FindGameObjectsWithTag("NumNaIons").Length > 0) GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value;

        if (GameObject.FindGameObjectWithTag("clToggle").GetComponent<Toggle>().isOn)
        {
            int numAtoms = GameObject.FindGameObjectsWithTag("ChlorineAtom").Length;

            if (numAtoms < (int)(clSlider.value))
            {

                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, (int)Math.Floor(clSlider.value - numAtoms), 0);
                numAtoms++;

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
    }

    public void HandleKSliderChange(Slider kSlider)
    {
        if (GameObject.FindGameObjectWithTag("kToggle").GetComponent<Toggle>().isOn)
        {
            int numAtoms = GameObject.FindGameObjectsWithTag("PotassiumAtom").Length;

            if (numAtoms < (int)(kSlider.value))
            {
                    GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, (int)Math.Floor(kSlider.value - numAtoms));
                    numAtoms++;
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
    }

    public void HandleInverseVoltmeterChange(Slider iVSlider)
    {
        int NaOuter = 0;
        int NaInner = 0;
        ArrayList NaIonsOuter = new ArrayList();
        ArrayList NaIonsInner = new ArrayList();

        foreach (GameObject ion in GameObject.FindGameObjectsWithTag("SodiumAtom"))
        {
            if (ion.transform.position.y > 214.95)
            {
                NaOuter++;
                NaIonsOuter.Add(ion);
            }
            else
            {
                NaInner++;
                NaIonsInner.Add(ion);
            }
        }

        float currentVoltage = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage();
        float desiredVoltage = iVSlider.GetComponent<Slider>().value;

        int numAtoms = (int)Mathf.Abs(currentVoltage - desiredVoltage);
        Debug.Log(numAtoms);

        if (currentVoltage < desiredVoltage)
        {
            if (NaIonsInner.Count < NaIonsOuter.Count)
            {
                for (int i = 0; i < numAtoms; i++)
                {
                    Debug.Log("added to inner");
                    if (i < NaIonsOuter.Count)
                    {
                        Destroy(NaIonsOuter[i] as GameObject);
                        NaIonsOuter.RemoveAt(i);
                    } else GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 1, 0, 0, false); ;
                }
            }
            else
            {
                for (int i = 0; i < numAtoms; i++)
                {
                    Debug.Log("removed from outer");
                    if (i < NaIonsOuter.Count)
                    {
                        Destroy(NaIonsOuter[i] as GameObject);
                        NaIonsOuter.RemoveAt(i);
                    }
                    else GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 1, 0, 0, false);
                }
            }
        } else if (currentVoltage > desiredVoltage)
        {
            if (NaIonsInner.Count > NaIonsOuter.Count)
            {
                for (int i = 0; i < numAtoms; i++)
                {
                    Debug.Log("added to outer");
                    if (i < NaIonsInner.Count)
                    {
                        Destroy(NaIonsInner[i] as GameObject);
                        NaIonsInner.RemoveAt(i);
                    } else GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 1, 0, 0, true);
                }
            }
            else
            {
                for (int i = 0; i < numAtoms; i++)
                {
                    Debug.Log("removed from inner");
                    if (i < NaIonsInner.Count)
                    {
                        Destroy(NaIonsInner[i] as GameObject);
                        NaIonsInner.RemoveAt(i);
                    }
                    else GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 1, 0, 0, true);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
        /*
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value * 30;
            GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value / 30;
        }
        */
    }
} 
