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
        if (prevSceneIndex >= 2)
        {
            SceneManager.LoadScene(prevSceneIndex);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings Menu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");     
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");     
    }

    public void changeScene(string theScene){
        SceneManager.LoadScene(theScene);     
    }

    public void infoScreen()
    {
        SceneManager.LoadScene("About Scene");
    }

    public void exitScene()
    {
        Application.Quit();
    }

    //Update is called once per frame
    void Update () {
		
	}
}
