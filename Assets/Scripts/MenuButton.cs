using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // The Scene to load when the "Reset" button is clicked
    public string sceneToLoad;

    // Reference to the pop-up box GameObject
    public GameObject popUpBox;

    // Reference to the "Reset" button in the pop-up box
    public Button resetButton;

    // Reference to the "Close" button in the pop-up box
    public Button closeButton;

    void Start()
    {
        // Add a listener to the "Reset" button, so it calls the ResetGame method when clicked
        resetButton.onClick.AddListener(ResetGame);

        // Add a listener to the "Close" button, so it calls the ClosePopUp method when clicked
        closeButton.onClick.AddListener(ClosePopUp);
    }

    public void OpenPopUp()
    {
        // Show the pop-up box
        popUpBox.SetActive(true);
    }

    public void ClosePopUp()
    {
        // Hide the pop-up box
        popUpBox.SetActive(false);
    }

    public void ResetGame()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
