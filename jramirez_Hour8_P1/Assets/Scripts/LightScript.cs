using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public float light_on = 1.2f;
    public float light_off = 0f;
    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            myLight.intensity = light_on;
        }
        else
        {
            myLight.intensity = light_off;
        }
    }
}
