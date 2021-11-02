using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public NavMeshAgent agent;
    public LineRenderer line;
    public List<Vector3> point;
    public Transform target;
    public Transform target1;
    public Transform target2;

    public GameObject Pinicio;
    public GameObject Camara;

    //public GameObject ObjetoClonar;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        line = GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        //if (Input.GetMouseButtonUp(0))
        //{
        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray,out hit))
        //    {
        //        agent.SetDestination(hit.point);
        //    }
        //}
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    agent.SetDestination(transform.position);
        //}
        //DisplayLineDestination();
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    PresionarBotonCofre1();
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    PresionarBotonCofre2();
        //}
        DisplayLineDestination();
    }

    private void DisplayLineDestination()
    {
        if (agent.path.corners.Length < 2)
        {
            return;
        }

        int i = 1;
        while (i<agent.path.corners.Length)
        {
            line.positionCount = agent.path.corners.Length;
            point = agent.path.corners.ToList();
            for (int j = 0; j < point.Count; j++)
            {
                line.SetPosition(j,point[j]);
            }
            i++;    
        }
    }

    public void PresionarBotonCofre1()
    {
        BoxCollider bx = target.GetComponent<BoxCollider>();
        bx.enabled = true;
        //StartCoroutine(tiempoesperaCofre1());
        agent.SetDestination(target.position);
    }

    public void PresionarBotonCofre2()
    {
        BoxCollider bx = target1.GetComponent<BoxCollider>();
        bx.enabled = true;
        //StartCoroutine(tiempoesperaCofre2());
        agent.SetDestination(target1.position);
    }

    public void PresionarBotonPuntoInicio()
    {

        agent.SetDestination(target2.position);
    }


    public IEnumerator tiempoesperaCofre2()
    {
        agent.SetDestination(this.transform.position);

        line.enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
        agent.enabled = false;
        this.transform.position = Pinicio.transform.position;
        agent.enabled = true;

        Camara.GetComponent<SeguimientoCamara>().enabled = false;
        Camara.GetComponent<SeguimientoRepetidorPlayerCofre2>().enabled = true;

        yield return new WaitForSeconds(3.5f);
        line.enabled = true;
        this.GetComponent<MeshRenderer>().enabled = true;
        
        agent.SetDestination(target1.position);
    }

    public IEnumerator tiempoesperaCofre1()
    {
        agent.SetDestination(this.transform.position);

        line.enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
        agent.enabled = false;
        this.transform.position = Pinicio.transform.position;
        agent.enabled = true;

        Camara.GetComponent<SeguimientoCamara>().enabled = false;
        Camara.GetComponent<SeguimientoCamaraPuntoInicio>().enabled = true;

        yield return new WaitForSeconds(3f);
        line.enabled = true;
        this.GetComponent<MeshRenderer>().enabled = true;

        agent.SetDestination(target.position);
    }
}
