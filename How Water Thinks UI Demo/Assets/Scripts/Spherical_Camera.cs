using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript;

public class Spherical_Camera : MonoBehaviour
{

    public float zoomspeed = 5.0f;
    public GameObject targetobject;
    public float rotatespeed = 4.0f;
    private Vector3 point;
    private Quaternion startRotation;
    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        point = targetobject.transform.position; // + new Vector3(-2.0f, 0.0f, 0.0f);
        transform.LookAt(point);
        startRotation = transform.rotation;
        startPosition = transform.position;
    }

    public void ResetCamera()
    {
        transform.rotation = startRotation;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Keypad6))
        {
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Keypad4))
        {
            transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.Keypad7))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, -1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Keypad9))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, 1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Keypad5))
        {
            transform.RotateAround(point, new Vector3(1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Keypad8))
        {
            transform.RotateAround(point, new Vector3(-1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.KeypadMinus) || Input.GetKey(KeyCode.Minus))
        {
            transform.position -= transform.forward * zoomspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.Plus))
        {
            transform.position += transform.forward * zoomspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            ResetCamera();
        }
    }
}