using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleForceTrigger : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter(Collider c)
    {
        bool letThrough = false;
        float reflectChance = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().reflectChance;
        //if (reflectChance < 2) reflectChance = 2.0f;
        if (Random.Range(1.0f, 100.0f) <= reflectChance) letThrough = true;

        //float voltageOuter = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageOuter();
        //float voltageInner = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltageInner();
        float totalVoltage = GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getVoltage();

        if (this.tag == "NaForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (totalVoltage > (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
                {
                    if (c.gameObject.transform.position.y <= 214.95)
                    {
                        //Debug.Log("100% chance of sodium from inner to outer.");
                        return;
                    }
                }
                if (totalVoltage < (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
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
        else if (this.tag == "ClForce")
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
                if (totalVoltage < (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
                {
                    if (c.gameObject.transform.position.y <= 214.95)
                    {
                        //Debug.Log("100% chance of chlorine from inner to outer.");
                        return;
                    }
                }
                if (totalVoltage > (GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage()))
                {
                    if (c.gameObject.transform.position.y > 214.95)
                    {
                        Debug.Log("100% chance of chlorine from outer to inner.");
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
        }
        else if (this.tag == "KForce")
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
    void Update()
    {
        //Debug.Log(GameObject.FindGameObjectWithTag("RunControl").GetComponent<AtomCount>().getTargetVoltage());
    }
}
