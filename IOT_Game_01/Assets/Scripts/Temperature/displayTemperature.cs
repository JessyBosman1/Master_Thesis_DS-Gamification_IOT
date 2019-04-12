using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayTemperature : MonoBehaviour  
{
    public Text display;

    // Start is called before the first frame update
    void Start()
    {
        display.text = temperature.roomTemperature.ToString() + "°C";
    }

    // Update is called once per frame
    void Update()
    {
       display.text = temperature.roomTemperature.ToString() + "°C";
    }

    public void TempUp() {
        print("UP");
        if (temperature.roomTemperature < 30) {temperature.roomTemperature += 1;}
    }

    public void TempDown() {
        if (temperature.roomTemperature > 15) {temperature.roomTemperature -= 1;}
    }

}
