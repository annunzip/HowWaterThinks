using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CheckboxColor : MonoBehaviour
{

    //Colors
    //Na+ is 182/199/255/255
    //K+ is 170/249/255/255
    //Cl is 255/151/151/255

    private Toggle checkbox;
    public Color color;
    public ColorBlock cb;
    public bool isOn;

    private void Start()
    {
        checkbox = GetComponent<Toggle>();
        checkbox.onValueChanged.AddListener(OnToggleValueChanged);
        cb = checkbox.colors;

        if (checkbox.isOn == true)
        {
            cb.normalColor = color;
            cb.highlightedColor = color;
        }
        else
        {
            cb.normalColor = Color.white;
            cb.highlightedColor = Color.white;
        }

        checkbox.colors = cb;
    }

    private void OnToggleValueChanged(bool isOn)
    {

        if (isOn)
        {
            cb.normalColor = color;
            cb.highlightedColor = color;
        }
        else
        {
            cb.normalColor = Color.white;
            cb.highlightedColor = Color.white;
        }

        checkbox.colors = cb;
    }
}
