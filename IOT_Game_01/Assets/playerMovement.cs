using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMovement : MonoBehaviour
{

    private Animator anim;
    private NavMeshAgent navMeshAgent;
    private Transform targetedObject;
    private Ray shootRay;
    private RaycastHit shootHit;

    private bool enemyClicked;


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
            print("mousedown");
            if (Physics.Raycast(ray, out hit, 100))
            {

                if (hit.collider.CompareTag("smartObject"))
                {
                    targetedObject = hit.transform;
                    ClickedObject();
                }

                else
                {
                    anim.SetBool("isWalking", true);
                    enemyClicked = false;
                    navMeshAgent.destination = hit.point;
#pragma warning disable CS0618 // Type or member is obsolete
                    navMeshAgent.Resume();
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            if (!navMeshAgent.hasPath || Mathf.Abs(navMeshAgent.velocity.sqrMagnitude) < float.Epsilon)
                anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }




    }

    private void ClickedObject(){
        print("SMART");
        targetedObject.gameObject.transform.Find("Canvas").gameObject.SetActive(true);
    }
}

