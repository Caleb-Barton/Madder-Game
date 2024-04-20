using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepMovement1 : MonoBehaviour
{
    Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        rigid = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(0, 5, 0);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(0, -5, 0);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(-5, 0, 0);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(5, 0, 0);
    }
}