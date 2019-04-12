using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMovement : MonoBehaviour
{
    public GameObject mark;

    private Animator anim;
    private NavMeshAgent navMeshAgent;
    private Transform targetedObject;
    private Ray shootRay;
    private RaycastHit shootHit;



    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
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

                if (hit.collider.CompareTag("smartObject") || hit.collider.CompareTag("clickable"))
                {
                    targetedObject = hit.transform;
                    ClickedObject();
                }

                else if (hit.collider.CompareTag("Canvas") || hit.collider.CompareTag("lightSwitch"))
                {

                }

                else
                {
                    anim.SetBool("isWalking", true);
                    navMeshAgent.destination = hit.point;
#pragma warning disable CS0618 // Type or member is obsolete
                    navMeshAgent.Resume();
#pragma warning restore CS0618 // Type or member is obsolete



                    // move the mark to the clicked position + offset
                    Vector3 markOffset = new Vector3(0, 0.2f, 0);
                    mark.transform.position = hit.point + markOffset;

                }
            }
        }

        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            if (!navMeshAgent.hasPath || Mathf.Abs(navMeshAgent.velocity.sqrMagnitude) < float.Epsilon)
                anim.SetBool("isWalking", false);
                //mark.transform.position = new Vector3(0, -100, 0);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }




    }

    private void ClickedObject(){
        targetedObject.gameObject.transform.Find("Canvas").gameObject.SetActive(true);
    }
}

