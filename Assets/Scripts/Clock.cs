using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public PlayerTimer Player1;
    public PlayerTimer Player2;
    public PlayerTimer Player3;
    public PlayerTimer Player4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.TimerIsRunning)
            TimeOn(Player1);
        if (Player2.TimerIsRunning)
            TimeOn(Player2);
        if (Player3.TimerIsRunning)
            TimeOn(Player3);
        if (Player4.TimerIsRunning)
            TimeOn(Player4);
        DisplayTime();
    }

    public void TimeOn(PlayerTimer player)
    {
        if (player.TimeRemaining > 0)
        {
            player.TimeRemaining -= Time.deltaTime;
        }
        else
        {
            Debug.Log($"Time has run out for {nameof(player)}");
            player.TimeRemaining = 0;
            player.TimerIsRunning = false;
        }
    }

    public void DisplayTime()
    {
        Player1.DisplayTime(Player1.TimeRemaining);
        Player2.DisplayTime(Player2.TimeRemaining);
        Player3.DisplayTime(Player3.TimeRemaining);
        Player4.DisplayTime(Player4.TimeRemaining);
    }
}
