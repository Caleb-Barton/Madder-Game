using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepMovement1 : MonoBehaviour
{
    Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = this.gameObject.GetComponent<Rigidbody2D>();
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

public class CollisionHandler1 : MonoBehaviour
{
    // Called when a collision begins
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Enter");

        // Check if the collision is with an object named "stopper"
        if (collision.gameObject.name.StartsWith("Stopper"))
        {
            // Add your code for handling collision enter here
            Debug.Log("Blocked");

            // For example, you can prevent the player from moving
            // by setting its velocity to zero
            Rigidbody2D playerRb = GetComponent<Rigidbody2D>();
            playerRb.velocity = Vector2.zero;
        }
    }

    // Called when a collision ends
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exit");

        // Check if the collision is with an object named "stopper"
        if (collision.gameObject.name.StartsWith("Stopper"))
        {
            // Add your code for handling collision exit here
            Debug.Log("Un-Blocked");
        }
    }
}