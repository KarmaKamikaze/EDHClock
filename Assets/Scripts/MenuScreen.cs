using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MenuScreen : MonoBehaviour
{
    public TMP_Dropdown timeLimitDropdown;
    public Button startButton;
    public string gameSceneName;

    // Start is called before the first frame update
    void Start()
    {
        // Fill the time limit dropdown with options
        timeLimitDropdown.ClearOptions();
        timeLimitDropdown.AddOptions(new List<string> { "20 minutes", "30 minutes", "40 minutes", "50 minutes", "1 hour" });

        // Set the default selected option to be "1 minute"
        timeLimitDropdown.value = 1;

        // Add a listener for the start button's onClick event
        startButton.onClick.AddListener(StartGame);
    }

    // This function is called when the start button is clicked
    void StartGame()
    {
        // Get the selected time limit from the dropdown
        int timeLimit = 0;
        switch (timeLimitDropdown.value)
        {
            case 0:
                timeLimit = 20 * 60;
                break;
            case 1:
                timeLimit = 30 * 60;
                break;
            case 2:
                timeLimit = 40 * 60;
                break;
            case 3:
                timeLimit = 50 * 60;
                break;
            case 4:
                timeLimit = 60 * 60;
                break;
        }

        // Save the selected time limit in PlayerPrefs
        PlayerPrefs.SetInt("TimeLimit", timeLimit);

        // Load the next scene
        SceneManager.LoadScene(gameSceneName);
    }
}
