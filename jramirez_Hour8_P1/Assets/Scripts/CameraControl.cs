using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");

        if(Input.GetMouseButton(0))
        {
            transform.Translate(mouseXvalue, mouseYvalue, 0);
        }
    }
}
