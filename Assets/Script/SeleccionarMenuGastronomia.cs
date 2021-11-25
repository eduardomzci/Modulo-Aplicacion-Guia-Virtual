using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarMenuGastronomia : MonoBehaviour
{
    public GameObject menu;
    public GameObject Panel;
    public GameObject Salir;

    public GameObject Objetivo0;
    public GameObject Objetivo1;
    public GameObject Objetivo2;
    //public GameObject Objetivo3;
    //public GameObject PuntoInicio;
    public void PresionarMenu()
    {
        menu.SetActive(false);
        Panel.SetActive(true);
        Salir.SetActive(true);

        Objetivo0.SetActive(true);
        Objetivo1.SetActive(true);
        Objetivo2.SetActive(true);
        //Objetivo3.SetActive(true);
    }
    public void PresionarSalir()
    {
        menu.SetActive(true);
        Panel.SetActive(false);
        Salir.SetActive(false);

        Objetivo0.SetActive(false);
        Objetivo1.SetActive(false);
        Objetivo2.SetActive(false);
        //Objetivo3.SetActive(false);

    }
}
