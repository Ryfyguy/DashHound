using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static string winner = "";
    public static float time = -4.0f;
    public static float timeStamp = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (winner != "" && timeStamp == 0)
        {
            timeStamp = time;
        }
        if (time - timeStamp >= 3)
        {
            


        }
        if (Button.State == 5)
        {
            if (time - timeStamp >= 5)
            {
                if (Alert.p2score < 3 && Alert.p1score < 3)
                {
                    Player1Key.spriteRenderer.sprite = Player1Key.None;
                    Player2Key.spriteRenderer.sprite = Player2Key.None;
                    if (winner == "player1")
                    {
                        Alert.p1score += 1;
                    }
                    else if (winner == "player2")
                    {
                        Alert.p2score += 1;
                    }
                    checkWin(2);
                    Default();
                    
                }
                checkWin(2);

            }
        }
        if (Button.State == 7)
        {
            if (time - timeStamp >= 5)
            {
                if (Alert.p2score < 5 && Alert.p1score < 5)
                {


                    if (winner == "player1")
                    {
                        Alert.p1score += 1;
                    }
                    else if (winner == "player2")
                    {
                        Alert.p2score += 1;
                    }
                    checkWin(4);
                    Default();
                    
                }
                else
                {
                    checkWin(4);
                }
                
                

            }
        }
    }

    void Default()
    {
        winner = "";
        time = -4.0f;
        timeStamp = 0;
        Player1Key.random = 0;
        Player2Key.random = 0;
        Player1Key.spriteRenderer.sprite = Player1Key.None;
        Player2Key.spriteRenderer.sprite = Player2Key.None;
        Player.keyPressed = true;
        Player2.keyPressed = true;
        
    }

    void checkWin(int i)
    {
        if (Alert.p1score >= i)
        {
            if (time - timeStamp >= 8)
            {
                Alert.p1score = 0;
                Alert.p2score = 0;
                P1wl.spriteRenderer.sprite = P1wl.None;
                P2wl.spriteRenderer.sprite = P2wl.None;
                Default();
                Alert.DoTick = true;
                SceneManager.LoadScene("Title");
            }
        }
        else if (Alert.p2score >= i)
        {

            if (time - timeStamp >= 8)
            {
                Alert.p1score = 0;
                Alert.p2score = 0;
                P1wl.spriteRenderer.sprite = P1wl.None;
                P2wl.spriteRenderer.sprite = P2wl.None;
                Default();
                Alert.DoTick = true;
                SceneManager.LoadScene("Title");
            }
        }
    }
}
    

