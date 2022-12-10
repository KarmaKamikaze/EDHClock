using UnityEngine;
using UnityEngine.UI;

public class ButtonGrid : MonoBehaviour
{
    // the buttons to use in the grid
    public GameObject[] buttons;

    void Start()
    {
        // calculate the size and position of each button
        float buttonWidth = Screen.width / 2;
        float buttonHeight = Screen.height / 2;

        // create a grid of buttons
        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 2; x++)
            {
                // get the button to use
                int index = y * 2 + x;
                GameObject button = buttons[index];

                // set the button's position and size
                RectTransform rectTransform = button.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2(
                    x * buttonWidth - (Screen.width - buttonWidth) / 2,
                    -y * buttonHeight + (Screen.height - buttonHeight) / 2
                );
                rectTransform.sizeDelta = new Vector2(buttonWidth, buttonHeight);
            }
        }
    }
}
