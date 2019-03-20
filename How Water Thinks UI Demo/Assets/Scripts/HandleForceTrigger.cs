using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleForceTrigger : MonoBehaviour {

    public Texture temp;
    public Texture temp1;

	// Use this for initialization
	void Start () {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if (this.tag == "NaForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                c.gameObject.GetComponent<Renderer>().material.mainTexture = temp;
            } else if (c.gameObject.tag == "ChlorineAtom")
            {
                Debug.Log("Denied Chlorine");
                //c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                //c.gameObject.GetComponent<Renderer>().material.mainTexture = temp1;
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                } else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            } else if (c.gameObject.tag == "PotassiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            }
        } else if (this.tag == "ClForce")
        {
            Debug.Log("entered");
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            }
            else if (c.gameObject.tag == "ChlorineAtom")
            {
                c.gameObject.GetComponent<Renderer>().material.mainTexture = temp;
            }
            else if (c.gameObject.tag == "PotassiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            }
        } else if (this.tag == "KForce")
        {
            if (c.gameObject.tag == "SodiumAtom")
            {
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            }
            else if (c.gameObject.tag == "ChlorineAtom")
            {
                Debug.Log("Denied Chlorine");
                //c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                if (c.gameObject.transform.position.y > 214.95)
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));
                }
                else
                {
                    c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -1000, 0));
                }
            }
            else if (c.gameObject.tag == "PotassiumAtom")
            {   
                c.gameObject.GetComponent<Renderer>().material.mainTexture = temp;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
