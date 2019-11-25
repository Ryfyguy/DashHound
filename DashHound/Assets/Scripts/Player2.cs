﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public bool keyPressed;
    public Sprite neutral;
    public Sprite winning;
    public Sprite losing;


    public static float p2time = -200f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = neutral;
        }
        keyPressed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && keyPressed)
        {
            p2time = Game.time;
            keyPressed = false;
            if (p2time < 0)
            {
                Game.winner = "player1";
            }
            else if (p2time < Player.p1time || Player.p1time == -200f)
            {
                Game.winner = "player2";
            }
        }

        if (Game.winner == "player2")
        {
            spriteRenderer.sprite = winning;
        }
        else if (Game.winner == "player1")
        {
            spriteRenderer.sprite = losing;
        }
        else
        {
            spriteRenderer.sprite = neutral;
        }
    }
}

