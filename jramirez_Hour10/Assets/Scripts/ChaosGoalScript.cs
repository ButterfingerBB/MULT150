using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public float chaosBalls = 7;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            if (chaosBalls == 1)
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
                Destroy(collidedWith);
            }
            else if (chaosBalls > 1)
            {
                chaosBalls = chaosBalls - 1;
                Destroy(collidedWith);
            }
        }
    }
}
