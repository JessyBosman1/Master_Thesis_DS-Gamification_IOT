using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barManager : MonoBehaviour
{
    public string selectedNeed;
    public Image content;
    public Color fullColor;
    public Color lowColor;

    private float selected;

    // Start is called before the first frame update
    void Start()
    {
        if (selectedNeed == "Hunger") { selected = Needs.Hunger; }
        else if (selectedNeed == "Sleep") { selected = Needs.Sleep; }
        else if (selectedNeed == "Hygiene") { selected = Needs.Hygiene; }
        else if (selectedNeed == "Bladder") { selected = Needs.Bladder; }
        else if (selectedNeed == "Happiness") { selected = Needs.Happiness; }

        content.fillAmount = selected/100;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateValues();
        updateColor();

    }

    private void updateColor()
    {
        content.color = Color.Lerp(lowColor, fullColor, content.fillAmount);
    }

    private void UpdateValues() {
        if (selectedNeed == "Hunger") { selected = Needs.Hunger; }
        else if (selectedNeed == "Sleep") { selected = Needs.Sleep; }
        else if (selectedNeed == "Hygiene") { selected = Needs.Hygiene; }
        else if (selectedNeed == "Bladder") { selected = Needs.Bladder; }
        else if (selectedNeed == "Happiness") { selected = Needs.Happiness; }
        print(selected);
        content.fillAmount = selected / 100;
    }
}
