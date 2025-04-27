using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered RTrigger");
    }
    void OnTriggerStay(Collider other)
    { 
        print(other.gameObject.name + "is still in RTrigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left RTrigger");
    }
}
