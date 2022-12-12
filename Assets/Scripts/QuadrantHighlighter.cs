using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class QuadrantHighlighter : MonoBehaviour
{
    public bool highlightTopLeft { get; set; } = false;
    public bool highlightTopRight { get; set; } = false;
    public bool highlightBottomLeft { get; set; } = false;
    public bool highlightBottomRight { get; set; } = false;
    public int offset = 10;

    public Color highlightColor = Color.yellow;

    public int sortingOrder = 0;

    void OnGUI()
    {
        // set the sorting order of the GUI
        GUI.depth = sortingOrder;

        // get the width and height of the screen
        int width = Screen.width;
        int height = Screen.height;

        // calculate the positions of the quardrants
        int topLeftX = 0;
        int topLeftY = 0;
        int topRightX = width / 2;
        int topRightY = 0;
        int bottomLeftX = 0;
        int bottomLeftY = height / 2;
        int bottomRightX = width / 2;
        int bottomRightY = height / 2;

        // set the color of the GUI
        GUI.color = highlightColor;

        // highlight the top-left quadrant if the highlightTopLeft variable is true
        if (highlightTopLeft)
        {
            EditorGUI.DrawRect(new Rect(topLeftX, topLeftY, width / 2, height / 2), highlightColor);
        }

        // highlight the top-right quadrant if the highlightTopRight variable is true
        if (highlightTopRight)
        {
            EditorGUI.DrawRect(new Rect(topRightX, topRightY, width / 2, height / 2), highlightColor);
        }

        // highlight the bottom-left quadrant if the highlightBottomLeft variable is true
        if (highlightBottomLeft)
        {
            EditorGUI.DrawRect(new Rect(bottomLeftX, bottomLeftY, width / 2, height / 2), highlightColor);
        }

        // highlight the bottom-right quadrant if the highlightBottomRight variable is true
        if (highlightBottomRight)
        {
            EditorGUI.DrawRect(new Rect(bottomRightX, bottomRightY, width / 2, height / 2), highlightColor);
        }
    }

    public void SetTopLeft()
    {
        highlightTopLeft = !highlightTopLeft;
    }

    public void SetTopRight()
    {
        highlightTopRight = !highlightTopRight;
    }

    public void SetBottomLeft()
    {
        highlightBottomLeft = !highlightBottomLeft;
    }

    public void SetBottomRight()
    {
        highlightBottomRight = !highlightBottomRight;
    }
}
