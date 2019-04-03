using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Tutorial_Change : MonoBehaviour {
	public Button butt;
	public Canvas CanvasA;
	public Canvas CanvasB;

	// Use this for initialization
	void Start () {
		Button btn = butt.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        CanvasA.gameObject.SetActive(true);
        CanvasB.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void TaskOnClick() {
		if(CanvasA.gameObject.activeSelf == true){
			CanvasA.gameObject.SetActive(false);
			CanvasB.gameObject.SetActive(true);
		}else{
			CanvasA.gameObject.SetActive(true);
			CanvasB.gameObject.SetActive(false);
		}
	}
}
