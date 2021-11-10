using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Objetivo2 : MonoBehaviour
{
    public GameObject Jplayer;
    public GameObject Pinicio;
    public Vector3 posicionDeInicio;

    //public GameObject Camara;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PersonajeSecuenciaDeMovimiento pl = other.GetComponent<PersonajeSecuenciaDeMovimiento>();
            pl.agent.SetDestination(other.gameObject.transform.position);
            BoxCollider bx = this.GetComponent<BoxCollider>();
            bx.enabled = false;

            StartCoroutine(tiempoespera());
        }
    }

    public IEnumerator tiempoespera()
    {
        Jplayer.GetComponent<LineRenderer>().enabled = false;
        Jplayer.GetComponent<MeshRenderer>().enabled = false;
        Jplayer.GetComponent<NavMeshAgent>().enabled = false;
        Jplayer.transform.position = Pinicio.transform.position;
        posicionDeInicio = Pinicio.transform.position;
        Jplayer.GetComponent<NavMeshAgent>().enabled = true;

        //Camara.GetComponent<SeguimientoCamara>().enabled = false;
        //Camara.GetComponent<SeguimientoRepetidorPlayerCofre2>().enabled = true;

        yield return new WaitForSeconds(2.0f);
        Jplayer.GetComponent<LineRenderer>().enabled = true;
        Jplayer.GetComponent<MeshRenderer>().enabled = true;
        PersonajeSecuenciaDeMovimiento pl1 = Jplayer.GetComponent<PersonajeSecuenciaDeMovimiento>();
        pl1.Presionar_Objetivo_2();
    }
}
