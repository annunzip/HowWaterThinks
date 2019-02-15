using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAtoms : MonoBehaviour {

    public int numberOfAtoms;
    public GameObject atom;
    float freeEnergy;
    Transform atomTransform;

    // Use this for initialization
    public void StartCreatingMolecules (float L, float l) {

        atomTransform = atom.transform;

        freeEnergy = 1f;
        CreateNAtoms(L, l);
	}

    void CreateNAtoms(float L, float l) {

        for (int i = 0; i < numberOfAtoms; i++)
        {

            //Debug.Log ("Entering CreateNAtoms");
            // Create an ion in a box
            atomTransform.position = CreateAtomPosition(L, l);
            Vector3 atomPosition = atomTransform.position;



            // Create a clone of atom at atomPosition
            GameObject atomclone = Instantiate(atom, atomPosition, Quaternion.identity);



            // Set initial velocity
            //atomclone.GetComponent<Rigidbody>().velocity = Vector3.up;
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


        // Choose a number number in the set 1, -1
        plusMinus = CreatePlusMinus();
        // Calculate z position of new molecule
        float zatom = Random.Range(l / 2f, L / 2f) * plusMinus;

        // Create a position vector
        Vector3 atomPosition = new Vector3(xatom, yatom, zatom);

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
