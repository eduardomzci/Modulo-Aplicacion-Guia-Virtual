using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class PersonajeSecuenciaDeMovimiento : MonoBehaviour
{
    public Rigidbody rb;
    public NavMeshAgent agent;
    public LineRenderer line;
    public List<Vector3> point;
    public Transform target;
    public Transform target1;
    public Transform target2;
    public Transform target3;

    public GameObject Pinicio;
    //public GameObject Camara;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        line = GetComponent<LineRenderer>();
    }


    void Update()
    {
        DisplayLineDestination();
    }

    private void DisplayLineDestination()
    {
        if (agent.path.corners.Length < 2)
        {
            return;
        }

        int i = 1;
        while (i < agent.path.corners.Length)
        {
            line.positionCount = agent.path.corners.Length;
            point = agent.path.corners.ToList();
            for (int j = 0; j < point.Count; j++)
            {
                line.SetPosition(j, point[j]);
            }
            i++;
        }
    }

    public void Presionar_Objetivo_0()
    {
        BoxCollider bx = target.GetComponent<BoxCollider>();
        bx.enabled = true;
        agent.SetDestination(target.position);
    }

    public void Presionar_Objetivo_1()
    {
        BoxCollider bx = target1.GetComponent<BoxCollider>();
        bx.enabled = true;
        agent.SetDestination(target1.position);
    }

    public void Presionar_Objetivo_2()
    {
        BoxCollider bx = target2.GetComponent<BoxCollider>();
        bx.enabled = true;
        agent.SetDestination(target2.position);
    }
    public void Presionar_Objetivo_3()
    {
        BoxCollider bx = target3.GetComponent<BoxCollider>();
        bx.enabled = true;
        agent.SetDestination(target3.position);
    }
}
