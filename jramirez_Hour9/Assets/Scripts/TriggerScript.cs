using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered LTrigger");
    }
    void OnTriggerStay(Collider other)
    { 
        print(other.gameObject.name + "is still in LTrigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left LTrigger");
    }
}
