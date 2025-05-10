using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        // The B key will generate a prefab at the position of the original prefab
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        // The space key will generate a prefab at the position of the spawn object
        // this script is attached to
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
