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
        if (reflectChance < 5) reflectChance = 5.0f;
        if (Random.Range(1.0f, 100.0f) < reflectChance) letThrough = true;

        if (this.tag == "NaForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
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
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
