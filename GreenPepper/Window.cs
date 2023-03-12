using System.Text;

namespace GreenPepper;

public class Window
{
    public readonly int width;
    public readonly int height;

    public Window(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public string Build()
    {
        StringBuilder builder = new();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                builder.Append(' ');
            }
        }

        return builder.ToString();
    }
}
