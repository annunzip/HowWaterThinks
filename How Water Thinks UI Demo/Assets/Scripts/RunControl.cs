using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunControl : MonoBehaviour
{

    // This set of routines appears in almost every scene. GameObject = RunControl


    public float boxSideLength;
    public float channelSideLength;

    GameObject runControl;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        GameObject atoms = GameObject.FindGameObjectWithTag("Atoms");

        if (sceneName == "Scene 4")
        {

            RemoveAllMolecules();
            //Debug.Log("ConstructChannel Membrane");

            // Create the basic membrane with a square hole in the middle
            //ConstructMembrane(boxSideLength, channelSideLength);

            // Construct the channel that goes in the hole in the membrane
            //ConstructChannel(channelSideLength);

            //atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(boxSideLength, channelSideLength);
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);

            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms;
            GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms;
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms;
        }
        else if (sceneName == "Scene 1")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);
        }
        else if (sceneName == "Scene 2" ||sceneName == "Scene 3")
        {
            RemoveAllMolecules();
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms, atoms.GetComponent<CreateAtoms>().numberOfChlorineAtoms, atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms);

            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfSodiumAtoms;
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value = atoms.GetComponent<CreateAtoms>().numberOfPotassiumAtoms;
        }
    }



    void RemoveAllMolecules()
    {

        GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
        GameObject[] chlorineAtomClones = GameObject.FindGameObjectsWithTag("ChlorineAtom");
        GameObject[] potassiumAtomClones = GameObject.FindGameObjectsWithTag("PotassiumAtom");

        foreach (GameObject atomClone in sodiumAtomClones)
        {
            Destroy(atomClone);
        }

        foreach (GameObject atomClone in chlorineAtomClones)
        {
            Destroy(atomClone);
        }

        foreach (GameObject atomClone in potassiumAtomClones)
        {
            Destroy(atomClone);
        }
    }





    float GetBoxSideLength()
    {

        // A box side length of corresponds to 100 nm.
        float boxSide = 1f;

        return boxSide;

    }




    float GetChannelSideLength()
    {

        float channelSide;

        channelSide = channelSideLength;

        //Debug.Log ("sceneFlag in GetChannelSideLength = " + sceneFlag);

        channelSide = 0.1f;

        //Debug.Log ("channelSide = " + channelSide);

        /*
		else {

			Debug.Log ("sceneFlag in else = " + sceneFlag);

			// A channel side length of 0.1 corresponds to 10 nm.
			GameObject sliderRoutines = GameObject.FindGameObjectWithTag("Sliders");
			channelSide = sliderRoutines.GetComponent<SliderChannelWidth> ().valueOfChannelSlider;

		}
		*/


        //Debug.Log ("channelSide = " + channelSide);

        return channelSide;
    }

    public void FastForward()
    {
        if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 0) Time.timeScale = 1;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 1) Time.timeScale = 2;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 2) Time.timeScale = 5;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 3) Time.timeScale = 10;
        else if (GameObject.FindGameObjectWithTag("FastForward").GetComponent<Dropdown>().value == 4) Time.timeScale = 25;


    }


    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            foreach (GameObject atom in GameObject.FindGameObjectsWithTag("PotassiumAtom"))
            {
                if (atom.transform.position.y > 214.95)
                {
                    Destroy(atom);
                    GameObject.Find("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 0, 0, 1);
                }
            }
        }
    }
}
