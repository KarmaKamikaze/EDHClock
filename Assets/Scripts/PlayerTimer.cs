using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTimer : MonoBehaviour
{
    public TMP_Text TimeText;
    public float TimeRemaining { get; set; }
    public bool TimerIsRunning { get; set; }

    public void Start()
    {
        TimeRemaining = PlayerPrefs.GetInt("TimeLimit");
        TimerIsRunning = false;
    }

    public void DisplayTime(float timeToDisplay)
    {
        // timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        TimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Pause()
    {
        TimerIsRunning = !TimerIsRunning;
    }
}
