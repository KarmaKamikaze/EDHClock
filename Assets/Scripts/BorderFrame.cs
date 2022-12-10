using UnityEngine;

public class BorderFrame : MonoBehaviour
{
    public int edgeThickness = 10; // thickness of the border frame edges
    public int cornerRadius = 20; // radius of the rounded corners
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

        // calculate the positions of the rounded corners
        int topLeftX = offset;
        int topLeftY = offset;
        int topRightX = width - cornerRadius - offset;
        int topRightY = offset;
        int bottomLeftX = offset;
        int bottomLeftY = height - cornerRadius - offset;
        int bottomRightX = width - cornerRadius - offset;
        int bottomRightY = height - cornerRadius - offset;

        // draw the top edge of the border frame
        GUI.DrawTexture(new Rect(topLeftX + cornerRadius, topLeftY, width - 2 * (offset + cornerRadius), edgeThickness),
            CreateHorizontalTexture(width - 2 * (offset + cornerRadius), edgeThickness));

        // draw the bottom edge of the border frame
        GUI.DrawTexture(
            new Rect(bottomLeftX + cornerRadius, bottomLeftY, width - 2 * (offset + cornerRadius), edgeThickness),
            CreateHorizontalTexture(width - 2 * (offset + cornerRadius), edgeThickness));

        // draw the left edge of the border frame
        GUI.DrawTexture(
            new Rect(topLeftX, topLeftY + cornerRadius, edgeThickness, height - 2 * (offset + cornerRadius)),
            CreateVerticalTexture(edgeThickness, height - 2 * (offset + cornerRadius)));

        // draw the right edge of the border frame
        GUI.DrawTexture(
            new Rect(topRightX, topRightY + cornerRadius, edgeThickness, height - 2 * (offset + cornerRadius)),
            CreateVerticalTexture(edgeThickness, height - 2 * (offset + cornerRadius)));

        // draw the top-left corner of the border frame
        GUI.DrawTexture(new Rect(topLeftX, topLeftY, cornerRadius, cornerRadius), CreateTopLeftCorner(cornerRadius));

        // draw the top-right corner of the border frame
        GUI.DrawTexture(new Rect(topRightX, topRightY, cornerRadius, cornerRadius), CreateTopRightCorner(cornerRadius));

        // draw the bottom-left corner of the border frame
        GUI.DrawTexture(new Rect(bottomLeftX, bottomLeftY, cornerRadius, cornerRadius),
            CreateBottomLeftCorner(cornerRadius));

        // draw the bottom-right corner of the border frame
        GUI.DrawTexture(new Rect(bottomRightX, bottomRightY, cornerRadius, cornerRadius),
            CreateBottomRightCorner(cornerRadius));
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

    // function to create a top-left corner texture
    Texture2D CreateTopLeftCorner(int radius)
    {
        // create a new texture with the specified radius
        Texture2D texture = new Texture2D(radius, radius);

        // set the color of the texture
        Color[] colors = new Color[radius * radius];
        for (int y = 0; y < radius; y++)
        {
            for (int x = 0; x < radius; x++)
            {
                if (x >= y)
                    colors[x + y * radius] = color;
            }
        }

        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }

    // function to create a top-right corner texture
    Texture2D CreateTopRightCorner(int radius)
    {
        // create a new texture with the specified radius
        Texture2D texture = new Texture2D(radius, radius);

        // set the color of the texture
        Color[] colors = new Color[radius * radius];
        for (int y = 0; y < radius; y++)
        {
            for (int x = 0; x < radius; x++)
            {
                if (x <= y)
                    colors[x + y * radius] = color;
            }
        }

        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }

    // function to create a bottom-left corner texture
    Texture2D CreateBottomLeftCorner(int radius)
    {
        // create a new texture with the specified radius
        Texture2D texture = new Texture2D(radius, radius);

        // set the color of the texture
        Color[] colors = new Color[radius * radius];
        for (int y = 0; y < radius; y++)
        {
            for (int x = 0; x < radius; x++)
            {
                if (x <= radius - y - 1)
                    colors[x + y * radius] = color;
            }
        }

        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }

    // function to create a bottom-right corner texture
    Texture2D CreateBottomRightCorner(int radius)
    {
        // create a new texture with the specified radius
        Texture2D texture = new Texture2D(radius, radius);

        // set the color of the texture
        Color[] colors = new Color[radius * radius];
        for (int y = 0; y < radius; y++)
        {
            for (int x = 0; x < radius; x++)
            {
                if (x >= radius - y - 1)
                    colors[x + y * radius] = color;
            }
        }

        texture.SetPixels(colors);

        // apply the changes to the texture
        texture.Apply();

        // return the texture
        return texture;
    }
}
