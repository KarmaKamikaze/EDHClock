using UnityEngine;

public class ScreenDivider : MonoBehaviour
{
    public int thickness = 1; // thickness of the screen dividers
    public int offset = 0; // offset of the screen dividers from the sides of the screen
    public Color color = Color.black; // color of the screen dividers
    public int sortingOrder = 0;

    void OnGUI()
    {
        // set the sorting order of the GUI
        GUI.depth = sortingOrder;

        // set the color of the GUI
        GUI.color = color;

        // get the width and height of the screen
        int width = Screen.width;
        int height = Screen.height;

        // calculate the positions of the screen dividers
        int x1 = width / 2 - thickness / 2 - offset;
        int y1 = height / 2 - thickness / 2 - offset;
        int x2 = x1 + thickness;
        int y2 = y1 + thickness;

        // draw the vertical screen divider
        GUI.DrawTexture(new Rect(x1 + offset, offset, thickness, height - 2 * offset),
            CreateVerticalTexture(thickness, height - 2 * offset));

        // draw the horizontal screen divider
        GUI.DrawTexture(new Rect(offset, y1 + offset, width - 2 * offset, thickness),
            CreateHorizontalTexture(width - 2 * offset, thickness));
    }

    // function to create a horizontal texture
    Texture2D CreateHorizontalTexture(int width, int height)
    {
        // create a new texture with the specified width and height
        Texture2D texture = new Texture2D(width, height);

        // set the color of the texture
        Color[] colors = new Color[width * height];
        for (int i = 0; i < colors.Length; i++)
            colors[i] = color;
        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }

    // function to create a vertical texture
    Texture2D CreateVerticalTexture(int width, int height)
    {
        // create a new texture with the specified width and height
        Texture2D texture = new Texture2D(width, height);

        // set the color of the texture
        Color[] colors = new Color[width * height];
        for (int i = 0; i < colors.Length; i++)
            colors[i] = color;
        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }
}
