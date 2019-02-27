using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomCount : MonoBehaviour {

    public int numAtomsOuter;
    public int numAtomsInner;
    public float voltageOuter;
    public float voltageInner;
    public float voltage;

    // Use this for initialization
    void Start () {
		
	}

    public float getVoltageOuter()
    {
        return voltageOuter;
    }

    public float getVoltageInner()
    {
        return voltageInner;
    }

    public float getVoltage()
    {
        return voltage;
    }

    // Update is called once per frame
    void Update () {
        //Getting the number of atoms inside and outside
        numAtomsOuter = 0;
        numAtomsInner = 0;
        voltageOuter = 0;
        voltageInner = 0;
        voltage = 0;

        foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom")) {
            if (atom.transform.position.y > 214.95)
            {
                numAtomsOuter++;
                voltage++;
                voltageOuter++;
            }
            else
            {
                numAtomsInner++;
                voltage--;
                voltageInner++;
            }
        }
        foreach (GameObject atom in GameObject.FindGameObjectsWithTag("ChlorineAtom"))
        {
            if (atom.transform.position.y > 214.95)
            {
                numAtomsOuter++;
                voltage--;
                voltageOuter--;

            }
            else
            {
                numAtomsInner++;
                voltage++;
                voltageInner--;
            }

        }
        foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom"))
        {
            if (atom.transform.position.y > 214.95)
            {
                numAtomsOuter += 1;
                voltage++;
                voltageOuter++;
            }
            else
            {
                numAtomsInner += 1;
                voltage--;
                voltageInner++;
            }
        }

        
        GameObject.FindGameObjectWithTag("AtomsOutsideCounterText").GetComponent<Text>().text = "Atoms Outside: " + numAtomsOuter;
        GameObject.FindGameObjectWithTag("AtomsInsideCounterText").GetComponent<Text>().text = "Atoms Inside: " + numAtomsInner;
        GameObject.FindGameObjectWithTag("VoltageOutsideCounterText").GetComponent<Text>().text = "Voltage Outside: " + voltageOuter;
        GameObject.FindGameObjectWithTag("VoltageInsideCounterText").GetComponent<Text>().text = "Voltage Inside: " + voltageInner;
        //Debug.Log("numAtomsOuter = " + numAtomsOuter);
        //Debug.Log("numAtomsInner = " + numAtomsInner);

        //Handling voltage
        float maxVoltage = GameObject.FindGameObjectsWithTag("SodiumAtom").Length + GameObject.FindGameObjectsWithTag("ChlorineAtom").Length + GameObject.FindGameObjectsWithTag("PotassiumAtom").Length;
        GameObject.FindGameObjectWithTag("VoltmeterTextTop").GetComponent<Text>().text = (GameObject.FindGameObjectsWithTag("SodiumAtom").Length + GameObject.FindGameObjectsWithTag("ChlorineAtom").Length + GameObject.FindGameObjectsWithTag("PotassiumAtom").Length).ToString();

        /*if (voltage > 0) GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color((voltage/maxVoltage*255f)/255f, 0f/255f, 0f/255f);
        else if (voltage < 0) GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color(0f/0f, 0f/0f, (-voltage/maxVoltage*255f)/255f);
        else GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color(0f/255f, 0f/255f, 0f/255f);
        Debug.Log(voltage);*/

        //Setting voltage slider values
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().minValue = -maxVoltage;
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().maxValue = maxVoltage;
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().value = voltage;

        /*
        //Gradient creation and application
        Gradient grad = new Gradient();
        GradientColorKey[] colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.blue;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.red;
        colorKey[1].time = 1.0f;

        GradientAlphaKey[] alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;

        grad.SetKeys(colorKey, alphaKey);
        */

        if (voltage > 0) GameObject.FindGameObjectWithTag("Voltage").GetComponentInChildren<Image>().color = new Color((voltage / maxVoltage * 255f) / 255f, 0f / 255f, 0f / 255f);
        else if (voltage < 0) GameObject.FindGameObjectWithTag("Voltage").GetComponentInChildren<Image>().color = new Color(0f / 0f, 0f / 0f, (-voltage / maxVoltage * 255f) / 255f);
        else GameObject.FindGameObjectWithTag("Voltage").GetComponentInChildren<Image>().color = new Color(0f / 255f, 0f / 255f, 0f / 255f);
    }
}
