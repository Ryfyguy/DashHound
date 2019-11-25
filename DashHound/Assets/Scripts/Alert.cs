using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }  

    // Update is called once per frame
    void Update()
    {
        if (Game.time >= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
