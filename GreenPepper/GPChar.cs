using Kodnix.Character;

namespace GreenPepper;

public struct GPChar
{
    public readonly string raw;
    public readonly int width;

    public GPChar(string raw)
    {
        this.raw = raw;
        this.width = EastAsianWidth.GetLength(raw);
    }
}