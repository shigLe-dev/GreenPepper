namespace ShigLe.TUITools.Drawers.Containers;

public class Container : IDrawer, IDrawable
{
    private readonly IDrawer drawer;

    public Container(IDrawable drawable)
    {
        drawer = drawable.GetDrawer();
    }

    public IDrawer GetDrawer()
    {
        return this;
    }

    public BoxConstraints GetConstraints(Size size)
    {
        return drawer.GetConstraints(size);
    }

    public IEnumerable<char> Draw(Position position, Size size)
    {
        using var enumerator = drawer.Draw(position, size).GetEnumerator();

        for (var y = 0; y < size.height; y++)
        for (var x = 0; x < size.width; x++)
        {
            enumerator.MoveNext();
            yield return enumerator.Current;
        }
    }
}