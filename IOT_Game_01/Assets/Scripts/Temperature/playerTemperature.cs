using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperature
{
    public static int roomTemperature = 20;
}

public class playerTemperature : MonoBehaviour
{
    public Canvas canvas;
    public Sprite hot;
    public Sprite cold;
    public static int feelingTemperature = 23;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkTemperature();
    }

    private void checkTemperature()
    {
        if (temperature.roomTemperature > feelingTemperature + 3)
        {
            canvas.gameObject.SetActive(true);
            canvas.GetComponentInChildren<Image>().sprite = hot;
        }
        else if (temperature.roomTemperature < feelingTemperature - 3)
        {
            canvas.gameObject.SetActive(true);
            canvas.GetComponentInChildren<Image>().sprite = cold;
        }
        else {
            canvas.gameObject.SetActive(false);
        }
    }
}
