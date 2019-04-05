using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleForceTrigger : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        bool letThrough = false;
        float reflectChance = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().reflectChance;
        if (reflectChance < 3) reflectChance = 3.0f;
        if (Random.Range(1.0f, 100.0f) <= reflectChance) letThrough = true;

        float voltageOuter = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter();
        float voltageInner = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageInner();

        if (this.tag == "NaForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (voltageInner > GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage())
                {
                    if (c.gameObject.transform.position.y <= 214.95)
                    {
                        //Debug.Log("100% chance of sodium from inner to outer.");
                        return;
                    }
                }
                if (voltageOuter > GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage())
                {
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        //Debug.Log("100% chance of sodium from outer to inner.");
                        return;
                    }
                }

                if (!letThrough)
                {
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                    }
                    else
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                    }
                }
            } else if (c.gameObject.tag == "ChlorineAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                } else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            } else if (c.gameObject.tag == "PotassiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            }
        } else if (this.tag == "ClForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            }
            else if (c.gameObject.tag == "ChlorineAtom")
            {
                if (voltageInner < GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage())
                {
                    if (c.gameObject.transform.position.y <= 214.95)
                    {
                        //Debug.Log("100% chance of chlorine from inner to outer.");
                        return;
                    }
                }
                if (voltageOuter < GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage())
                {
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        //Debug.Log("100% chance of chlorine from outer to inner.");
                        return;
                    }
                }

                if (!letThrough)
                {
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                    }
                    else
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                    }
                }
            }
            else if (c.gameObject.tag == "PotassiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            }
        } else if (this.tag == "KForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            }
            else if (c.gameObject.tag == "ChlorineAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                }
            }
            else if (c.gameObject.tag == "PotassiumAtom")
            {
                //if (!letThrough)
                //{
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
                    }
                    else
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -100, 0));
                    }
                //}
            }
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage());
	}
}
