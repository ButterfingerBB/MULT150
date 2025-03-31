using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float days = 0;
        while (days < 31)
        {
            if (days == 17)
            {
                Debug.Log("It's my birthday! Yippee!");
                days++;
            }
            else
            {
                days++;
                Debug.Log(days);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
