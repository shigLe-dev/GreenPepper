using System.Text;

namespace GreenPepper;

public struct GPText
{
    public readonly List<GPLine> lines;

    public GPText(params GPLine[] lines)
    {
        this.lines = lines.ToList();
    }

    public string Build(int width, int height)
    {
        StringBuilder builder = new();

        for (int i = 0; i < height; i++)
        {
            if (lines.Count > i) builder.Append(lines[i].Build(width));
            else builder.Append(new GPLine().Build(width));
        }

        return builder.ToString();
    }
}