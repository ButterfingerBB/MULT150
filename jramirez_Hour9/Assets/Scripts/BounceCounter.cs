using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    float collisions = 0;

    void OnCollisionEnter(Collision collision)
    {
        collisions = collisions + 1;
        Debug.Log(collisions);
    }
}
