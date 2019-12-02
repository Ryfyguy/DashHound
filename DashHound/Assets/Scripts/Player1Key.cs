using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Key : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    public Sprite Up;
    public Sprite Down;
    public Sprite Left;
    public Sprite Right;
    public Sprite Win;
    public Sprite Lose;
    public static int random = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.time >= 0 && Game.winner == "" && random == 0)
        {
            random = Random.Range(1, 5);
            if (random == 1)
            {
                spriteRenderer.sprite = Up;
            }
            else if (random == 2)
            {
                spriteRenderer.sprite = Down;
            }
            else if (random == 3)
            {
                spriteRenderer.sprite = Left;
            }
            else if (random == 4)
            {
                spriteRenderer.sprite = Right;
            }
        }
        else if (Game.winner == "player1")
        {
            spriteRenderer.sprite = Win;
        }
        else if (Game.winner == "player2")
        {
            spriteRenderer.sprite = Lose;
        }
    }
}
