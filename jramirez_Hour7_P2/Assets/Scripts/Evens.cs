using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var number = 20;
        while (number < 100)
        {
            number = number + 2;
            Debug.Log(number);
        }
    }
}