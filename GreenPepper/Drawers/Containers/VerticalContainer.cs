namespace ShigLe.TUITools.Drawers.Containers;

public class VerticalContainer : IDrawer, IDrawable
{
    private readonly IDrawer lowerDrawer;
    private readonly IDrawer upperDrawer;

    public VerticalContainer(IDrawable upperDrawer, IDrawable lowerDrawer)
    {
        this.upperDrawer = upperDrawer.GetDrawer();
        this.lowerDrawer = lowerDrawer.GetDrawer();
    }

    public IDrawer GetDrawer()
    {
        return this;
    }

    public BoxConstraints GetConstraints(Size size)
    {
        return BoxConstraints.Loose(size);
    }

    public IEnumerable<char> Draw(Position position, Size size)
    {
        var upperPosition = position;
        var upperSize = new Size(size.width, size.height / 2);

        var lowerPosition = new Position(position.x, position.y + upperSize.height);
        var lowerSize = new Size(size.width, size.height - upperSize.height);

        var upperEnumerator = upperDrawer.Draw(upperPosition, upperSize).GetEnumerator();
        var lowerEnumerator = lowerDrawer.Draw(lowerPosition, lowerSize).GetEnumerator();

        for (var currentY = 0; currentY < size.height; currentY++)
        for (var currentX = 0; currentX < size.width; currentX++)
        {
            var currentEnumerator = currentY < upperSize.height ? upperEnumerator : lowerEnumerator;
            currentEnumerator.MoveNext();
            yield return currentEnumerator.Current;
        }
    }
}