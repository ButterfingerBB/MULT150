using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator2 : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 startPosition;
    public float spacing;

    void Start()
    {
        // Spawn 10 lamps in a row, each of them being a set distance to the right of each other
        for (int i = 0; i < 10; i++)
        {
            Vector3 currentPosition = startPosition + Vector3.right * (i * spacing);
            Instantiate(prefab, currentPosition, Quaternion.identity);
        }
    }
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
