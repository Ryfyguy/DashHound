using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2wl : MonoBehaviour
{
    public static SpriteRenderer spriteRenderer;
    public Sprite Win;
    public Sprite Lose;
    public static Sprite None;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Alert.p1score >= 3 && Button.State == 5) || (Alert.p2score >= 3 && Button.State == 5) || (Alert.p2score >= 5 && Button.State == 7) || (Alert.p1score >= 5 && Button.State == 7))
        {
            if ((Alert.p2score >= 3 && Button.State == 5) || (Alert.p2score >= 5 && Button.State == 7))
            {
                spriteRenderer.sprite = Win;
                Player1Key.spriteRenderer.sprite = Player1Key.None;
                Player2Key.spriteRenderer.sprite = Player2Key.None;
                Dog.spriteRenderer.sprite = Dog.Win;
                Alert.DoTick = false;
            }
            else if ((Alert.p1score >= 3 && Button.State == 5) || (Alert.p1score >= 5 && Button.State == 7))
            {
                spriteRenderer.sprite = Lose;
                Player1Key.spriteRenderer.sprite = Player1Key.None;
                Player2Key.spriteRenderer.sprite = Player2Key.None;
                Dog.spriteRenderer.sprite = Dog.Win;
                Alert.DoTick = false;
            }
        }

    }
}
