using System.Text;

namespace ShigLe.TUITools;

public class GreenPepper
{
    public void Draw(int width, int height, IDrawer drawer)
    {
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;

        using var e = drawer.Draw(0, 0, width, height).GetEnumerator();
        var stringBuilder = new StringBuilder();

        while (e.MoveNext()) stringBuilder.Append(e.Current);

        Console.Write(stringBuilder.ToString());
    }

    public void Draw(IDrawer drawer)
    {
        Draw(Console.WindowWidth, Console.WindowHeight, drawer);
    }
}