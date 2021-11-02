using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject Panel;
    public GameObject Salir;

    public GameObject Cofre1;
    public GameObject Cofre2;
    //public GameObject PuntoInicio;
    public void PresionarMenu()
    {
        menu.SetActive(false);
        Panel.SetActive(true);
        Salir.SetActive(true);

        Cofre1.SetActive(true);
        Cofre2.SetActive(true);
        //PuntoInicio.SetActive(true);
    }
    public void PresionarSalir()
    {
        menu.SetActive(true);
        Panel.SetActive(false);
        Salir.SetActive(false);

        Cofre1.SetActive(false);
        Cofre2.SetActive(false);
        //PuntoInicio.SetActive(false);
    }

    
}
