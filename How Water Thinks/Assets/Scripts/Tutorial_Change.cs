using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Tutorial_Change : MonoBehaviour {
    public Button nextbtn;
    public Button backbtn;
    public Button nextbtntwo;
    public Button backbtntwo;
    public Canvas CanvasA;
    public Canvas CanvasB;
    public Canvas CanvasC;

    // Use this for initialization
    void Start () {
	CanvasA.gameObject.SetActive(true);
        CanvasB.gameObject.SetActive(false);
	CanvasC.gameObject.SetActive(false);
	Button btn1 = nextbtn.GetComponent<Button>();
	btn1.onClick.AddListener(CanvasAFunc);
        Button btn2 = nextbtntwo.GetComponent<Button>();
        btn2.onClick.AddListener(CanvasBNext);
        Button btn3 = backbtn.GetComponent<Button>();
        btn3.onClick.AddListener(CanvasBBack);
        Button btn4 = backbtntwo.GetComponent<Button>();
        btn4.onClick.AddListener(CanvasCBack);
    }
	
	// Update is called once per frame
	void CanvasAFunc() {
		CanvasA.gameObject.SetActive(false);
		CanvasB.gameObject.SetActive(true);
	}
	
	void CanvasBNext(){
		CanvasB.gameObject.SetActive(false);
		CanvasC.gameObject.SetActive(true);
	}

	void CanvasBBack(){
		CanvasB.gameObject.SetActive(false);
		CanvasA.gameObject.SetActive(true);
	}

	void CanvasCBack(){
		CanvasC.gameObject.SetActive(false);
		CanvasB.gameObject.SetActive(true);
	}
}
