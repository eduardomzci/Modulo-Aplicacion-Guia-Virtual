using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class CofreScript : MonoBehaviour
{
    public GameObject Jplayer;
    public GameObject Pinicio;
    public Vector3 posicionDeInicio;

    public GameObject Camara;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player pl = other.GetComponent<Player>();
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

        Camara.GetComponent<SeguimientoCamara>().enabled = false;
        Camara.GetComponent<SeguimientoCamaraPuntoInicio>().enabled = true;

        yield return new WaitForSeconds(3);
        Jplayer.GetComponent<LineRenderer>().enabled = true;
        Jplayer.GetComponent<MeshRenderer>().enabled = true;
        Player pl1 = Jplayer.GetComponent<Player>();
        pl1.PresionarBotonCofre1();

        
    }
}
