using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public Sprite[] playerSprites;
    public int spriteIndex = 0;
    Rigidbody rigid;
    

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.gameObject.GetComponent<Rigidbody>();
        GetComponent<SpriteRenderer>().sprite = playerSprites[spriteIndex];
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