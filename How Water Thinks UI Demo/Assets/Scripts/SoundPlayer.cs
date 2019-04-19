using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {

    public AudioClip toggleAudio, menuAudio; 

	// Use this for initialization
	void Start () {

	}

    public void PlayToggleAudio()
    {
        GetComponent<AudioSource>().clip = toggleAudio;
        GetComponent<AudioSource>().Play();
    }

    public void PlayMenuAudio()
    {
        GetComponent<AudioSource>().clip = menuAudio;
        GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
