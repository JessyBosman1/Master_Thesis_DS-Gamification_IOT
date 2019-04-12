using UnityEngine;

public class toggleTopFloor : MonoBehaviour
{
    public GameObject selectedObject;
    public bool initial = false;
    public bool onImpact = true;
    // Start is called before the first frame update
    void Start()
    {
        selectedObject.SetActive(initial);
    }

    // Update is called once per frame
    void Update()
    {

    }


    //void OnCollisionEnter(Collision other)
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            selectedObject.SetActive(onImpact);
            /*
            if (topActive == false)
            {
                topActive = true;
                topFloor.SetActive(topActive);
            }
            else {
                topActive = false;
                topFloor.SetActive(topActive);
            }
            */
        }
    }
}
