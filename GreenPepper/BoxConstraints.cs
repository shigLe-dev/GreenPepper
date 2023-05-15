namespace ShigLe.TUITools;

public struct BoxConstraints
{
    public readonly Size min;
    public readonly Size max;

    public BoxConstraints(Size min, Size max)
    {
        if (min.width > max.width ||
            min.height > max.height) throw new Exception("min > max");

        this.min = min;
        this.max = max;
    }

    public static BoxConstraints Tight(Size size)
    {
        return new BoxConstraints(size, size);
    }

    public static BoxConstraints Loose(Size size)
    {
        return new BoxConstraints(Size.zero, size);
    }
}