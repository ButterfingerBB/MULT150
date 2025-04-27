using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Input.GetKey("left") || Input.GetKey("right")) 
        {
            transform.Translate(horizontal, 0, 0);
        }
        if (Input.GetKey("up") || Input.GetKey("down"))
        {
            transform.Translate(0, vertical, 0);
        }
    }
}
