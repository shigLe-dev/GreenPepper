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

    public GPText Build()
    {
        GPLine[] lines = new GPLine[height];

        for (int y = 0; y < height; y++)
        {
            List<GPChar> chars = new();
            for (int x = 0; x < width; x++)
            {
                chars.Add(new("●"));
            }
            lines[y] = new(chars);
        }

        return new(lines);
    }
}
