using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraOrbital : MonoBehaviour
{
    Vector2 touchDeltaPosition;
    public Transform padreCamera;

    float Speed = 5.0f;

    public Vector3 chale;

    public bool bandera0;
    public bool bandera1;

    void Update()
    {
        chale = padreCamera.position;
        if (Input.GetMouseButton(0))
        {
            float pointer_x = Input.GetAxis("Mouse X");
            float pointer_y = Input.GetAxis("Mouse Y");
            transform.parent.Translate(-pointer_x * 0.1f, 0, -pointer_y * 0.1f);
            //if (transform.parent.position.x > -8.750818f && transform.parent.position.z < 5.9145f)
            //{
            //        //padreCamera.position = new Vector3(padreCamera.position.x, padreCamera.position.y, 5.9145f);

            //}
            //else
            //{
            //    if (transform.parent.position.x < -8.750818f)
            //    {
            //        bandera0 = true;
            //    }
            //    if (transform.parent.position.z > 5.9145f)
            //    {
            //        bandera1 = true;
            //    }
            //    if (bandera0==true && bandera1 == false)
            //    {
            //        padreCamera.position = new Vector3(-8.750818f, padreCamera.position.y, padreCamera.position.z);
            //        float pointer_x = Input.GetAxis("Mouse X");
            //        float pointer_y = Input.GetAxis("Mouse Y");
            //        transform.parent.Translate(-pointer_x * 0.1f, 0, -pointer_y * 0.1f);
            //    }
            //    if (bandera0==false && bandera1 == true)
            //    {
            //        padreCamera.position = new Vector3(padreCamera.position.x, padreCamera.position.y, 5.9145f);
            //        float pointer_x = Input.GetAxis("Mouse X");
            //        float pointer_y = Input.GetAxis("Mouse Y");
            //        transform.parent.Translate(-pointer_x * 0.1f, 0, -pointer_y * 0.1f);
            //    }
            //    if (bandera0 == true && bandera1 == true)
            //    {
            //        padreCamera.position = new Vector3(-8.750818f, padreCamera.position.y, 5.9145f);
            //        float pointer_x = Input.GetAxis("Mouse X");
            //        float pointer_y = Input.GetAxis("Mouse Y");
            //        transform.parent.Translate(-pointer_x * 0.1f, 0, -pointer_y * 0.1f);
            //    }
            //}
        }
        if (Input.GetMouseButton(1))
        {
            float pointer_x = Input.GetAxis("Mouse X");
            transform.parent.eulerAngles += Speed * new Vector3(0, Input.GetAxis("Mouse X"), 0);
        }

        //if (Input.touchCount == 1)
        //{
        //    Touch touchZero = Input.GetTouch(0);
        //    if (touchZero.phase == TouchPhase.Moved)
        //    {
        //        touchDeltaPosition = Input.GetTouch(0).deltaPosition;
        //        gameObject.transform.Rotate(touchDeltaPosition.y * .05f, -touchDeltaPosition.x * .4f, 0);
        //    }
        //}
    }
}
