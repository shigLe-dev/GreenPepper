using System.Text;

namespace GreenPepper;

public struct GPText
{
    private GPLine[] lines;

    public GPText(params GPLine[] lines)
    {
        this.lines = lines;
    }

    public string Build(int width, int height)
    {
        StringBuilder builder = new();

        for (int i = 0; i < height; i++)
        {
            if (lines.Length > i) builder.Append(lines[i].Build(width));
            else builder.Append(new GPLine().Build(width));
        }

        return builder.ToString();
    }
}