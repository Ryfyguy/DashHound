using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static string winner = "";
    public static float time = -2.0f;
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
        if (time - timeStamp >= 5)
        {
            if (winner == "player1")
            {
                Alert.p1score += 1;
            }
            else if (winner == "player2")
            {
                Alert.p2score += 1;
            }
            winner = "";
            time = -4.0f;
            timeStamp = 0;
            Player1Key.random = 0;
            Player2Key.random = 0;
            SceneManager.LoadScene("Title");
        }
    }
}
