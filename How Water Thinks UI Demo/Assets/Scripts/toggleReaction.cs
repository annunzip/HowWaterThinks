using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleReaction : MonoBehaviour {

    public GameObject ZeroMembrane;
    public GameObject NaMembrane;
    public GameObject ClMembrane;
    public GameObject KMembrane;
    public GameObject NaClMembrane;
    public GameObject NaKMembrane;
    public GameObject ClKMembrane;
    public GameObject NaClKMembrane;
    public GameObject NaForce;
    public GameObject NaLiner;
    public GameObject ClForce;
    public GameObject ClLiner;
    public GameObject KForce;
    public GameObject KLiner;

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

    public void HandleMembraneToggle()
    {
        bool NaOn = false;
        bool ClOn = false;
        bool KOn = false;
        if (GameObject.FindGameObjectsWithTag("NaChannelToggle").Length > 0) NaOn = GameObject.FindGameObjectWithTag("NaChannelToggle").GetComponent<Toggle>().isOn;
        if (GameObject.FindGameObjectsWithTag("ClChannelToggle").Length > 0) ClOn = GameObject.FindGameObjectWithTag("ClChannelToggle").GetComponent<Toggle>().isOn;
        if (GameObject.FindGameObjectsWithTag("KChannelToggle").Length > 0) KOn = GameObject.FindGameObjectWithTag("KChannelToggle").GetComponent<Toggle>().isOn;

        for (int i = 0; i < GameObject.FindGameObjectWithTag("ModelMembrane").transform.childCount; i++)
        {
            var child = GameObject.FindGameObjectWithTag("ModelMembrane").transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        if (!NaOn && !ClOn && !KOn)
        {
            ZeroMembrane.SetActive(true);
        } else if (NaOn && !ClOn && !KOn) //1
        {
            NaMembrane.SetActive(true);
            NaLiner.SetActive(true);
        }
        else if (!NaOn && ClOn && !KOn) //2
        {
            ClMembrane.SetActive(true);
            ClLiner.SetActive(true);
        }
        else if (!NaOn && !ClOn && KOn) //3
        {
            KMembrane.SetActive(true);
            KLiner.SetActive(true);
        }
        else if(NaOn && ClOn && !KOn) //1 2
        {
            NaClMembrane.SetActive(true);
            NaLiner.SetActive(true);
            ClLiner.SetActive(true);
        }
        else if (!NaOn && ClOn && KOn) //2 3
        {
            ClKMembrane.SetActive(true);
            ClLiner.SetActive(true);
            KLiner.SetActive(true);
        }
        else if (NaOn && !ClOn && KOn) //1 3
        {
            NaKMembrane.SetActive(true);
            NaLiner.SetActive(true);
            KLiner.SetActive(true);
        }
        else if (NaOn && ClOn && KOn) //1 2 3
        {
            NaClKMembrane.SetActive(true);
            NaLiner.SetActive(true);
            ClLiner.SetActive(true);
            KLiner.SetActive(true);
        }
    }

    public void HandleWaterToggle(Toggle waterToggle)
    {

    }

    public void HandleChargesToggle(Toggle chargesToggle)
    {

    }

    public void ToggleFullscreen(Toggle fullscreenToggle)
    {
        if (fullscreenToggle.isOn)
        {
            Screen.SetResolution(Screen.width, Screen.height, true);
        }
        else
        {
            Screen.SetResolution(Screen.width, Screen.height, false);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
