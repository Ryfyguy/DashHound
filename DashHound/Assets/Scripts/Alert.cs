using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alert : MonoBehaviour
{
    public static int p1score = 0;
    public static int p2score = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite wait;
    public Sprite go;
    AudioSource audioData;
    public Text p1scoreTxt;
    public Text p2scoreTxt;
    public static bool DoTick = true;


    // Start is called before the first frame update
    void Start()
    {
        //p1scoreTxt = GetComponent<Text>();
        //p2scoreTxt = GetComponent<Text>();
        audioData = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = wait;
            Dog.spriteRenderer.sprite = Dog.Default;
        }
    }  

    // Update is called once per frame
    void Update()
    {
        p1scoreTxt.text = (p1score).ToString();
        p2scoreTxt.text = (p2score).ToString();
        if (DoTick)
        {
            if (Game.time >= 0)
            {
                spriteRenderer.sprite = go;
                Dog.spriteRenderer.sprite = Dog.Go;

            }
            if (Game.time < 0 && Game.time >= -0.5)
            {
                audioData.Play(0);
            }
            if (Game.time < 0)
            {
                spriteRenderer.sprite = wait;
                Dog.spriteRenderer.sprite = Dog.Default;
            }
        }
    }
}
