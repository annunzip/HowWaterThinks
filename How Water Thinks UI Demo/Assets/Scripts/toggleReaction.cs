using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleReaction : MonoBehaviour {

    public GameObject membrane0;
    public GameObject membrane1;
    public GameObject NaForce;
    public GameObject NaLiner;

    // Use this for initialization
    void Start () {
		
	}

    public void HandleNaToggle(Toggle sodiumToggle)
    {
        if (sodiumToggle.isOn == true)
        {
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, (int)GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value, 0, 0);
        } else
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("SodiumAtom")) Destroy(atom);
        }
    }

    public void HandleClToggle(Toggle chlorineToggle)
    {
        if (chlorineToggle.isOn == true)
        {
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, (int)GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value, 0);
        }
        else
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("ChlorineAtom")) Destroy(atom);
        }
    }

    public void HandleKToggle(Toggle potassiumToggle)
    {
        if (potassiumToggle.isOn == true)
        {
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, (int)GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value);
        }
        else
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom")) Destroy(atom);
        }
    }

    public void HandleMembraneToggle(Toggle membraneToggle)
    {
        if (membraneToggle.isOn == true)
        {
            membrane0.SetActive(false);
            membrane1.SetActive(true);
            NaForce.SetActive(true);
            NaLiner.SetActive(true);
        }
        else
        {
            membrane1.SetActive(false);
            NaForce.SetActive(false);
            NaLiner.SetActive(false);
            membrane0.SetActive(true);

        }
    }

    public void HandleWaterToggle(Toggle waterToggle)
    {

    }

    public void HandleChargesToggle(Toggle chargesToggle)
    {

    }

    // Update is called once per frame
    void Update () {
		
	}
}
