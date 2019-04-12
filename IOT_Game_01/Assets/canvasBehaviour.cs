using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasBehaviour : MonoBehaviour
{
    public GameObject canvas;
    private Transform targetedObject;
    private Ray shootRay;
    private float KeyDownTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {

                if (!hit.collider.CompareTag("Canvas") & canvas.activeSelf == true)
                {
                    Invoke("hideCanvas", 0.5f);
                    //targetedObject.gameObject.transform.Find("CanvasLightSwitch").gameObject.SetActive(false);
                }

            }


        }


    }

    private void showCanvas()
    {
        //targetedObject.gameObject.transform.Find("CanvasLightSwitch").gameObject.SetActive(true);
        canvas.SetActive(true);
    }


    private void hideCanvas() {
        //targetedObject.gameObject.transform.Find("CanvasLightSwitch").gameObject.SetActive(false);
        canvas.SetActive(false);
    }

}
