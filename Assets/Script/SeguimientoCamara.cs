using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public GameObject follow;
    void Start()
    {

    }

    void Update()
    {
        float posX = follow.transform.position.x;
        float posZ = follow.transform.position.z;

        transform.position = new Vector3(posX +34f, transform.position.y, posZ -34f);
    }
}
