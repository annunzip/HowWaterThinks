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

    // Use this for initialization
    void Start()
    {
        point = targetobject.transform.position; // + new Vector3(-2.0f, 0.0f, 0.0f);
        transform.LookAt(point);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, -1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(point, new Vector3(0.0f, 0.0f, 1.0f), 20 * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            transform.position -= transform.forward * zoomspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            transform.position += transform.forward * zoomspeed * Time.deltaTime;
        }
    }
}