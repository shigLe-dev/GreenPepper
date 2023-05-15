namespace ShigLe.TUITools.Drawers.Containers;

public class HorizontalContainer : IDrawer, IDrawable
{
    private readonly IDrawer leftDrawer;
    private readonly IDrawer rightDrawer;

    public HorizontalContainer(IDrawable leftDrawer, IDrawable rightDrawer)
    {
        this.leftDrawer = leftDrawer.GetDrawer();
        this.rightDrawer = rightDrawer.GetDrawer();
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
        var leftPosition = position;
        var leftSize = new Size(size.width / 2, size.height);

        var rightPosition = new Position(position.x + leftSize.width, position.y);
        var rightSize = new Size(size.width - leftSize.width, size.height);

        var leftEnumerator = leftDrawer.Draw(leftPosition, leftSize).GetEnumerator();
        var rightEnumerator = rightDrawer.Draw(rightPosition, rightSize).GetEnumerator();

        for (var currentY = 0; currentY < size.height; currentY++)
        for (var currentX = 0; currentX < size.width; currentX++)
        {
            var currentEnumerator = currentX < leftSize.width ? leftEnumerator : rightEnumerator;
            currentEnumerator.MoveNext();
            yield return currentEnumerator.Current;
        }
    }
}