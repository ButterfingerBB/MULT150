using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    double healthpoints = 3992;
    double healing = 0;

    void Start()
    {
        healthpoints = UsePotion(healthpoints, 400);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints, 400);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints, 400);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints, 400);
        Debug.Log(healthpoints);
    }

    void Update()
    {
        
    }

    double UsePotion(double healthpoints, double healing)
    {
        return healthpoints + healing;
    }
}

