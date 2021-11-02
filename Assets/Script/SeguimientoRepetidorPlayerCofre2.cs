using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoRepetidorPlayerCofre2 : MonoBehaviour
{
    public GameObject PuntoInicio;
    public float limitex;
    public float limitez;
    public bool bandera1 = false;
    public bool bandera2 = false;
    public Vector3 Miposicion;
    void Start()
    {

    }

    void Update()
    {
        float posX = PuntoInicio.transform.position.x;
        float posZ = PuntoInicio.transform.position.z;
        limitex = posX + 34f;
        limitez = posZ - 34f;
        Miposicion = transform.position;
        if (bandera1 == false)
        {
            Miposicion.x = Miposicion.x - Time.deltaTime * 4f;
        }
        if (bandera2 == false)
        {
            Miposicion.z = Miposicion.z + Time.deltaTime * 5f;
        }

        if (Miposicion.x < limitex)
        {
            bandera1 = true;
        }
        if (Miposicion.z > limitez)
        {
            bandera2 = true;
        }

        if (bandera1 == false || bandera2 == false)
        {
            transform.position = new Vector3(Miposicion.x, transform.position.y, Miposicion.z);
        }

        if (bandera1 == true && bandera2 == true)
        {
            this.GetComponent<SeguimientoCamara>().enabled = true;
            this.GetComponent<SeguimientoRepetidorPlayerCofre2>().enabled = false;
            bandera1 = false;
            bandera2 = false;
        }
    }
}
