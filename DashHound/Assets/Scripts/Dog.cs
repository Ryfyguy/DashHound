using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public static SpriteRenderer spriteRenderer;
    public static Sprite Default;
    public static Sprite Go;
    public static Sprite Win;
    public Sprite test;
    public Sprite test2;
    public Sprite test3;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Default = test;
       Go = test2;
        Win = test3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
