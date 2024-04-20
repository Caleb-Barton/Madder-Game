using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_2 : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int speed = 5000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad8))
        {
            myRigidbody.velocity = (Vector2.up * speed) * Time.deltaTime;
            //transform.position.x = Mathf.Round(transform.position.x / 10) * 10;
            float gridLocation = Mathf.Round(transform.position.x / 10) * 10;
            if (gridLocation != transform.position.x)
            {
                transform.Translate(gridLocation - transform.position.x, 0, 0);
            }
            //transform.Translate(0, 10, 0);
        }
        else if (Input.GetKey(KeyCode.Keypad5))
        {
            myRigidbody.velocity = (Vector2.down * speed) * Time.deltaTime;
            float gridLocation = Mathf.Round(transform.position.x / 10) * 10;
            if (gridLocation != transform.position.x)
            {
                transform.Translate(gridLocation - transform.position.x, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.Keypad4))
        {
            myRigidbody.velocity = (Vector2.left * speed) * Time.deltaTime;
            float gridLocation = Mathf.Round(transform.position.y / 10) * 10;
            if (gridLocation != transform.position.y)
            {
                transform.Translate(0, gridLocation - transform.position.y, 0);
            }
        }
        else if (Input.GetKey(KeyCode.Keypad6))
        {
            myRigidbody.velocity = (Vector2.right * speed) * Time.deltaTime;
            float gridLocation = Mathf.Round(transform.position.y / 10) * 10;
            if (gridLocation != transform.position.y)
            {
                transform.Translate(0, gridLocation - transform.position.y, 0);
            }
        }
        else
        {
            float gridLocationX = Mathf.Round(transform.position.x / 10) * 10;
            float gridLocationY = Mathf.Round(transform.position.y / 10) * 10;
            if (gridLocationX != transform.position.x)
            {
                transform.Translate(gridLocationX - transform.position.x, 0, 0);
            }
            if (gridLocationY != transform.position.y)
            {
                transform.Translate(0, gridLocationY - transform.position.y, 0);
            }
            myRigidbody.velocity = Vector2.zero;
        }
    }

}

