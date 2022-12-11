using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonHandler : MonoBehaviour
{
    // the name of the scene to load when the back button is pressed
    public string sceneName;

    void Update()
    {
        // check if the back button is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
