using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomCount : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Getting the number of atoms inside and outside
        int numAtomsOuter = 0;
        int numAtomsInner = 0;
        float voltageOuter = 0;
        float voltageInner = 0;
        float voltage = 0;

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

        /*if (voltage > 0) GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color((voltage/maxVoltage*255f)/255f, 0f/255f, 0f/255f);
        else if (voltage < 0) GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color(0f/0f, 0f/0f, (-voltage/maxVoltage*255f)/255f);
        else GameObject.FindGameObjectWithTag("Voltage").GetComponent<Text>().color = new Color(0f/255f, 0f/255f, 0f/255f);
        Debug.Log(voltage);*/
        
        //Setting voltage slider values
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().minValue = 0;
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().maxValue = maxVoltage;
        GameObject.FindGameObjectWithTag("Voltage").GetComponent<Slider>().value = voltage;
    }
}
