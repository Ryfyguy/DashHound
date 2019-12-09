using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    public static int p1score = 0;
    public static int p2score = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite wait;
    public Sprite go;
    AudioSource audioData;
    
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = wait;
        }
    }  

    // Update is called once per frame
    void Update()
    {
        if (Game.time >= 0)
        {
            spriteRenderer.sprite = go;
            
        }
        if (Game.time <0 && Game.time >= -0.5)
        {
            audioData.Play(0);
        }
    }
}
