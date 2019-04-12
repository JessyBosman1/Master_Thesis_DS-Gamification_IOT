using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleLight()
    {
        foreach (Transform child in transform)
        {
            if (child.GetComponentInChildren<Light>().range == 0) { child.GetComponentInChildren<Light>().range = 12; }
            else { child.GetComponentInChildren<Light>().range = 0; }

            if (child.GetComponentInChildren<Light>().intensity == 0) { child.GetComponentInChildren<Light>().intensity = 0.6f; }
            else { child.GetComponentInChildren<Light>().intensity = 0; }
        }

    }
}
