using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void NextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    public void PrevScene()
    {
        int prevSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        if (prevSceneIndex >= 0)
        {
            SceneManager.LoadScene(prevSceneIndex);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
