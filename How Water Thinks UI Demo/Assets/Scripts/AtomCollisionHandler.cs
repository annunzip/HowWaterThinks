using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomCollisionHandler : MonoBehaviour {

    public Vector3 inVelA;
    public Vector3 outVelA;
    public Vector3 inVelB;
    public Vector3 outVelB;
    // Use this for initialization
    void Start () {
	    
	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "SodiumAtom" || col.gameObject.tag == "ChlorineAtom")
        {
            inVelA = this.GetComponent<Rigidbody>().velocity;
            inVelB = col.gameObject.GetComponent<Rigidbody>().velocity;
            //Debug.Log("inVel = " + inVelA);
        }
    }

    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "SodiumAtom" || col.gameObject.tag == "ChlorineAtom")
        {
            outVelA = this.GetComponent<Rigidbody>().velocity;
            outVelB = col.gameObject.GetComponent<Rigidbody>().velocity;
            //Debug.Log("outVel = " + outVelA);
            col.gameObject.GetComponent<Rigidbody>().velocity = -inVelA;// + new Vector3(-1, -1, -1);
            this.GetComponent<Rigidbody>().velocity = -inVelB;

            //col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(1, 1, 1);
        }
    }

    public void OnTriggerEnter(Collider atom)
    {
        if (atom.gameObject.tag == "PotassiumAtom" || atom.gameObject.tag == "ChlorineAtom")
        {
            Vector3 vel = atom.gameObject.GetComponent<Rigidbody>().velocity;
            if (atom.GetComponent<Rigidbody>() != null) atom.GetComponent<Rigidbody>().velocity = -vel;
        } 
    }

    public void OnTriggerStay(Collider atom)
    {
        float charge = 1f;
        float electricField = -(GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter() - GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage()); //-(VO - VI) / h;
        //Debug.Log(atom.GetComponent<Rigidbody>());
        if (atom.GetComponent<Rigidbody>() != null) atom.GetComponent<Rigidbody>().AddForce(transform.up * charge * electricField);
       /*if (atom.gameObject.tag == "PotassiumAtom")
        {
            Vector3 vel = atom.gameObject.GetComponent<Rigidbody>().velocity;
            if (atom.GetComponent<Rigidbody>() != null) atom.GetComponent<Rigidbody>().velocity = -vel;
        } */
    }

    public void OnTriggerExit(Collider atom)
    {
        float charge = 1f;
        float electricField = -(GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter() - GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage()); //-(VO - VI) / h;
        //Debug.Log(atom.GetComponent<Rigidbody>());
        if (atom.GetComponent<Rigidbody>() != null) atom.GetComponent<Rigidbody>().AddForce(transform.up * charge * electricField);
        /* if (atom.gameObject.tag == "PotassiumAtom")
        {
            Vector3 vel = atom.gameObject.GetComponent<Rigidbody>().velocity;
            if (atom.GetComponent<Rigidbody>() != null) atom.GetComponent<Rigidbody>().velocity = -vel;
        } */
    }

    // Update is called once per frame
    void Update () {
		
	}
}
