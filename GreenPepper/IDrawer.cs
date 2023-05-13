namespace ShigLe.TUITools;

public interface IDrawer
{
    IEnumerable<char> Draw(int x, int y, int width, int height);
}