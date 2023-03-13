using System.Text;

namespace GreenPepper;

public struct GPLine
{
    public readonly List<GPChar> chars;

    public GPLine()
    {
        chars = new();
    }

    public GPLine(IEnumerable<GPChar> chars)
    {
        this.chars = chars.ToList();
    }

    public string Build(int maxWidth)
    {
        StringBuilder builder = new();

        int currentWidth = 0;
        for (int i = 0; i < chars.Count; i++)
        {
            currentWidth += chars[i].width;

            if (currentWidth > maxWidth)
            {
                currentWidth -= chars[i].width;
                break;
            }

            builder.Append(chars[i].raw);
        }

        // 余りを足す
        for (int i = 0; i < maxWidth - currentWidth; i++)
            builder.Append(' ');

        return builder.ToString();
    }
}