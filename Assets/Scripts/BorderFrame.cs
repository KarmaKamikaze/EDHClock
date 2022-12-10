using UnityEngine;

public class BorderFrame : MonoBehaviour
{
    public int edgeThickness = 10; // thickness of the border frame edges
    public int offset = 5; // offset of the border frame from the edges of the screen
    public Color color = Color.black; // color of the border frame

    void OnGUI()
    {
        Draw();
    }

    public void Draw()
    {
        // set the color of the GUI
        GUI.color = color;

        // get the width and height of the screen
        int width = Screen.width;
        int height = Screen.height;

        // calculate the positions of the edges of the frame relative to the edges of the screen
        int topY = offset;
        int bottomY = height - offset;
        int leftX = offset;
        int rightX = width - offset;

        // draw the top edge of the border frame
        GUI.DrawTexture(new Rect(leftX, topY, width - 2 * offset, edgeThickness),
            CreateHorizontalTexture(width - 2 * offset, edgeThickness));

        // draw the bottom edge of the border frame
        GUI.DrawTexture(new Rect(leftX, bottomY - edgeThickness, width - 2 * offset, edgeThickness),
            CreateHorizontalTexture(width - 2 * offset, edgeThickness));

        // draw the left edge of the border frame
        GUI.DrawTexture(new Rect(leftX, topY, edgeThickness, height - 2 * offset),
            CreateVerticalTexture(edgeThickness, height - 2 * offset));

        // draw the right edge of the border frame
        GUI.DrawTexture(new Rect(rightX - edgeThickness, topY, edgeThickness, height - 2 * offset),
            CreateVerticalTexture(edgeThickness, height - 2 * offset));
    }

    // function to create a horizontal texture
    Texture2D CreateHorizontalTexture(int width, int height)
    {
        // create a new texture with the specified dimensions
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
        // create a new texture with the specified dimensions
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
