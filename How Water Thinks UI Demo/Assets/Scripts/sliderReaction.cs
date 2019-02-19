using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderReaction : MonoBehaviour {

    //public Slider ionSlider;

    // Use this for initialization
    void Start () {

        //if (ionSlider == null) ionSlider = GameObject.FindGameObjectWithTag("NumIons").GetComponent<Slider>();

        //GameObject atoms = GameObject.FindGameObjectWithTag("Atoms");
        int numberOfSodiumAtoms = 50;
        int numberOfChlorineAtoms = 50;

        //Slider ionSlider = GameObject.FindGameObjectWithTag("NumIons").GetComponent<Slider>();
}

    public void SliderTest(Slider ionSlider)
    {
        //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfChlorineAtoms = (int)ionSlider.value;
        //GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().numberOfSodiumAtoms = (int)ionSlider.value;
        int numAtoms = GameObject.FindGameObjectsWithTag("SodiumAtom").Length + GameObject.FindGameObjectsWithTag("ChlorineAtom").Length;

        Debug.Log("numAtoms = " + numAtoms);
        Debug.Log("ionSlider.value = " + ionSlider.value);

        if (numAtoms/2 < ionSlider.value)
        {
            while (numAtoms/2 < ionSlider.value)
            {
                GameObject.FindGameObjectWithTag("Atoms").GetComponent<CreateAtoms>().AddNAtoms(1, 1, (int)(ionSlider.value - numAtoms/2));
                numAtoms += 2;
            }

        } else if (numAtoms / 2 > ionSlider.value)
        {
            while (numAtoms / 2 > ionSlider.value)
            {
                Destroy(GameObject.FindGameObjectsWithTag("SodiumAtom")[0]);
                Destroy(GameObject.FindGameObjectsWithTag("ChlorineAtom")[0]);
                numAtoms -= 2;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log("Test2");
    }
} 
