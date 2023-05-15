namespace ShigLe.TUITools;

public struct Size
{
    public readonly int width;
    public readonly int height;

    public static readonly Size zero = new();

    public Size(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
}