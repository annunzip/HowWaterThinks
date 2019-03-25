using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseVoltage : MonoBehaviour {

    public Slider NaSlider, ClSlider, KSlider;
    int minVoltage, maxVoltage;

    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("VoltageChanger").GetComponent<Slider>().value = 0;
    }

    public void HandleVoltageChange()
    {
        GameObject[] sodiumIons = GameObject.FindGameObjectsWithTag("SodiumAtom");

        foreach (GameObject ion in sodiumIons)
        {

        }
    }
	
	// Update is called once per frame
	void Update () {
        maxVoltage = (int)(NaSlider.maxValue + ClSlider.maxValue + KSlider.maxValue);
        minVoltage = -maxVoltage;

        GameObject.FindGameObjectWithTag("VoltageChanger").GetComponent<Slider>().maxValue = Mathf.Log(maxVoltage);
        GameObject.FindGameObjectWithTag("VoltageChanger").GetComponent<Slider>().minValue = -Mathf.Log(maxVoltage);
    }
}
