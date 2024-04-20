using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnScript : MonoBehaviour
{

    public GameObject Player_1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){

            Instantiate(Player_1, transform.position, transform.rotation);

        }
        
    }
}
