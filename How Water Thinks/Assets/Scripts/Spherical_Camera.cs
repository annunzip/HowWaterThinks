using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityScript;

public class Spherical_Camera : MonoBehaviour
{

    public float zoomspeed = 5.0f;
    public GameObject targetobject;
    public float rotatespeed = 4.0f;
    private Vector3 point;
    private Quaternion startRotation;
    private Vector3 startPosition;
    private ArrayList pos;
    private ArrayList rot;
    private int currentPos;

    // Use this for initialization
    void Start()
    {
        point = targetobject.transform.position; // + new Vector3(-2.0f, 0.0f, 0.0f);
        transform.LookAt(point);
        startRotation = transform.rotation;
        startPosition = transform.position;
        pos = new ArrayList();
        rot = new ArrayList();
        currentPos = 0;
        addPresets();

    }

    public void addPresets()
    {
        //preset 1
        pos.Add(new Vector3(660.53f,219.68f,-205.08f));
        rot.Add(Quaternion.Euler(84.41f,79.30f,79.82f));
        //preset 2
        pos.Add(new Vector3(660.53f,210.01f,-205.04f));
        rot.Add(Quaternion.Euler(-84.41f,85.94f,-85.35f));
        //preset 3
        pos.Add(new Vector3(658.91f,215.26f,-205.01f));
        rot.Add(Quaternion.Euler(11.18f,89.56f,-40.94f));
        //preset 4
        //pos.Add(new Vector3(661.77f,215.00f,-204.66f));
        //rot.Add(Quaternion.Euler(10.47f,-113.74f,118.33f));
        //preset 5
        pos.Add(new Vector3(660.85f,214.87f,-205.00f));
        rot.Add(Quaternion.Euler(-6.22f,-89.77f,-178.30f));
        //preset 6
        pos.Add(new Vector3(660.35f,214.92f,-205.00f));
        rot.Add(Quaternion.Euler(-6.22f,-89.77f,-178.304f));
        //preset 7
        pos.Add(new Vector3(663.63f,215.00f,-203.65f));
        rot.Add(Quaternion.Euler(3.315f,-117.30f,94.40f));
        
        // Back to start (make sure this is always the last one added)
        pos.Add(startPosition);
        rot.Add(startRotation);
    }

    public void ResetCamera()
    {
        transform.rotation = startRotation;
        transform.position = startPosition;
    }

    public void PresetCamera()
    {
        //Debug.Log(currentPos);
        if(currentPos != 0 && currentPos == (pos.Count))
        {
            transform.position = (Vector3)pos[0];
            transform.rotation = (Quaternion)rot[0];
            currentPos = 0;
        }
        else
        {
            transform.position = (Vector3)pos[currentPos];
            transform.rotation = (Quaternion)rot[currentPos];
            currentPos += 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Keypad6))
        {
            transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Keypad4))
        {
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.Keypad7))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, 1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Keypad9))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, -1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Keypad5))
        {
            transform.RotateAround(point, new Vector3(-1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Keypad8))
        {
            transform.RotateAround(point, new Vector3(1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * rotatespeed); 
        }

        if (Input.GetKey(KeyCode.KeypadMinus) || Input.GetKey(KeyCode.Minus))
        {
            transform.position -= transform.forward * zoomspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.Equals))
        {
            transform.position += transform.forward * zoomspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            ResetCamera();
            currentPos = 0;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            PresetCamera();
        }
    }
}