using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float gridLocationX = Mathf.Round(transform.position.x / 10) * 10;
        float gridLocationY = Mathf.Round(transform.position.y / 10) * 10;
        if (gridLocationX != transform.position.x || gridLocationY != transform.position.y)
        {
            MoveToLocation(gridLocationX, gridLocationY);
        }
    }

    void MoveToLocation(float targetX, float targetY)
    {
        // Calculate direction towards the target location
        Vector2 direction = new Vector2(targetX - transform.position.x, targetY - transform.position.y).normalized;

        // Calculate the magnitude of the force required to move towards the target location
        float distance = Vector2.Distance(new Vector2(targetX, targetY), new Vector2(transform.position.x, transform.position.y)) / 10;
        float forceMagnitude = (distance / Time.deltaTime);

        // Apply force to move towards the target location
        rigidBody.AddForce(direction * forceMagnitude, ForceMode2D.Force);
    }
}

