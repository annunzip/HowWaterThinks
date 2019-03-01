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
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Debug.Log(sceneName);

        if (sceneName == "Scene 3")
        {

            RemoveAllMolecules();
            //Debug.Log("ConstructChannel Membrane");

            // Create the basic membrane with a square hole in the middle
            //ConstructMembrane(boxSideLength, channelSideLength);

            // Construct the channel that goes in the hole in the membrane
            //ConstructChannel(channelSideLength);

            GameObject atoms = GameObject.FindGameObjectWithTag("Atoms");
            //atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(boxSideLength, channelSideLength);
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);

            GameObject.FindGameObjectWithTag("NumNaIons").GetComponent<Slider>().value = GameObject.FindGameObjectsWithTag("SodiumAtom").Length;
            GameObject.FindGameObjectWithTag("NumClIons").GetComponent<Slider>().value = GameObject.FindGameObjectsWithTag("ChlorineAtom").Length;
            GameObject.FindGameObjectWithTag("NumKIons").GetComponent<Slider>().value = GameObject.FindGameObjectsWithTag("PotassiumAtom").Length;
        }
        else if (sceneName == "Scene 1")
        {
            RemoveAllMolecules();
            GameObject atoms = GameObject.FindGameObjectWithTag("Atoms");
            atoms.GetComponent<CreateAtoms>().StartCreatingMolecules(1, 1);
            RemoveAllMolecules();
            GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, 100, 0, 0);

        }
    }



    void RemoveAllMolecules()
    {

        GameObject[] sodiumAtomClones = GameObject.FindGameObjectsWithTag("SodiumAtom");
        GameObject[] chlorineAtomClones = GameObject.FindGameObjectsWithTag("ChlorineAtom");

        foreach (GameObject atomClone in sodiumAtomClones)
        {
            Destroy(atomClone);
        }

        foreach (GameObject atomClone in chlorineAtomClones)
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


    // Update is called once per frame
    void Update()
    {

    }
}
