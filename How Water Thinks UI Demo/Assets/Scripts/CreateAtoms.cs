using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAtoms : MonoBehaviour {

    public int numberOfSodiumAtoms;
    public GameObject sodiumAtom;
    public int numberOfChlorineAtoms;
    public GameObject chlorineAtom;
    public int numberOfPotassiumAtoms;
    public GameObject potassiumAtom;
    public Vector3 kAtomPosition;
    float freeEnergy;
    Transform atomTransform;

    // Use this for initialization
    public void StartCreatingMolecules (float L, float l) {

        atomTransform = sodiumAtom.transform;

        freeEnergy = 1f;
        CreateNAtoms(L, l);
	}

    void CreateNAtoms(float L, float l) {

        for (int i = 0; i < numberOfSodiumAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(sodiumAtom, atomPosition, Quaternion.identity);



            // Set initial velocity
            atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }

        for (int i = 0; i < numberOfChlorineAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(chlorineAtom, atomPosition, Quaternion.identity);



            // Set initial velocity
            atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }
    }

    public void AddNAtoms(float L, float l, int numNaAtoms, int numClAtoms, int numKAtoms)
    {

        for (int i = 0; i < numNaAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(sodiumAtom, atomPosition, Quaternion.identity);



            // Set initial velocity
            atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }

        for (int i = 0; i < numClAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(chlorineAtom, atomPosition, Quaternion.identity);



            // Set initial velocity
            atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }

        for (int i = 0; i < numKAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(potassiumAtom, kAtomPosition, Quaternion.identity);



            // Set initial velocity
            atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }
    }

    Vector3 CreateAtomPosition(float L, float l)
    {

        //Debug.Log ("Entering CreateAtomPosition");

        float plusMinus;

        L = 0.7f * L;

        // Choose a number number in the set 1, -1
        plusMinus = CreatePlusMinus();

        // Calculate x position of new molecule
        float xatom = Random.Range(l / 2f, L / 2f) * plusMinus;
        //float xatom = 661;

        // Calculate y position of new molecule
        float probThreshold = 0.5f * (1f - freeEnergy);
        float yatom;
        if (Random.value > probThreshold)
        {
            yatom = Random.Range(l, L / 2f);
        }
        else
        {
            yatom = -Random.Range(l, L / 2f);
        }
        //float yatom = 215;


        // Choose a number number in the set 1, -1
        plusMinus = CreatePlusMinus();
        // Calculate z position of new molecule
        float zatom = Random.Range(l / 2f, L / 2f) * plusMinus;
        //float zatom = -205;

        // Create a position vector
        Vector3 atomPosition = new Vector3(661 + xatom, 215 + yatom, -205 + zatom);
        kAtomPosition = new Vector3(661+ xatom, 214 + yatom, -205 + zatom);

        //Debug.Log(atomPosition);
        return atomPosition;

    }

    float CreatePlusMinus()
    {

        float plusMinus;

        if (Random.value > 0.5)
        {
            plusMinus = 1f;
        }
        else
        {
            plusMinus = -1f;
        }

        return plusMinus;
    }

 

    // Update is called once per frame
    void Update () {
		
	}
}
