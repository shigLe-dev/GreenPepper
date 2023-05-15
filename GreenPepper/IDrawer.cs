namespace ShigLe.TUITools;

public interface IDrawer
{
    BoxConstraints GetConstraints(Size size);

    IEnumerable<char> Draw(Position position, Size size);
}