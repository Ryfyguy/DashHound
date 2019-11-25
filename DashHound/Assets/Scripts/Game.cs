using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static string winner = "";
    public float p2time = Player2.p2time;
    public static float time = -8.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
      
        if (Player.p1time != -200f || p2time != -200f)
        {

            if (Player.p1time < p2time)
            {
                if (Player.p1time < 0f)
                {
                    winner = "player2";
                }
                else
                {
                    winner = "player1";
                }
            }
            else if (p2time < Player.p1time)
            {
                if (p2time < 0f)
                {
                    winner = "player1";
                }
                else
                {
                    winner = "player1";
                }
            }
            
        }
        

    }
}
