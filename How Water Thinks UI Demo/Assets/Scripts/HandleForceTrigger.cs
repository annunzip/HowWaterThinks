using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleForceTrigger : MonoBehaviour {

    public Texture temp;

    int i = 0;
	// Use this for initialization
	void Start () {
        
    }

    /*
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "SodiumAtom")
        {
            Physics.IgnoreCollision(c.collider, GameObject.Find("ClForce").GetComponent<Collider>());
            c.gameObject.GetComponent<Renderer>().material.mainTexture = temp;
            c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        //Debug.Log(c.collider.tag);
        i++;
        Debug.Log(this.gameObject.tag + " " + i);
    }
    */

    // Update is called once per frame
    void Update () {
		
	}
}
