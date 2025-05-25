using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbController : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Recolor");
        }

        if (Input.GetKeyDown("d"))
        {
            animator.SetTrigger("Scale");
        }

        if (Input.GetKeyDown("s"))
        {
            animator.SetTrigger("Spin");
        }

        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("Hover");
        }
    }
}
