using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;

public class PlayerSpawnScript : MonoBehaviour
{
    public static Vector3 sP1 = new Vector3(50f,40f,-1f);
    public static Vector3 sP4 = new Vector3(40f,-50f,-1f);
    public static Vector3 sP3 = new Vector3(-50f,-40f,-1f);
    public static Vector3 sP2 = new Vector3(-40f,50f,-1f);
    public GameObject player;
    public static Vector3[] spawnPointArray = {sP1, sP2, sP3, sP4};
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            spawnPoint = spawnPointArray[Constants.Constants.playerIndex];
            Instantiate(player, spawnPoint, transform.rotation);
            Constants.Constants.playerIndex++;
        }
    }
}
