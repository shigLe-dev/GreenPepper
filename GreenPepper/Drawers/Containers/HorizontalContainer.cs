namespace ShigLe.TUITools.Drawers.Containers;

public class HorizontalContainer : IDrawer
{
    private readonly IDrawer leftDrawer;
    private readonly IDrawer rightDrawer;

    public HorizontalContainer(IDrawer rightDrawer, IDrawer leftDrawer)
    {
        this.rightDrawer = rightDrawer;
        this.leftDrawer = leftDrawer;
    }

    public IEnumerable<char> Draw(int x, int y, int width, int height)
    {
        var rightX = x;
        var rightY = y;
        var rightWidth = width / 2;
        var rightHeight = height;

        var leftX = rightWidth + 1;
        var leftY = y;
        var leftWidth = rightWidth + 1;
        var leftHeight = height;

        var rightEnumerator = rightDrawer.Draw(rightX, rightY, rightWidth, rightHeight).GetEnumerator();
        var leftEnumerator = leftDrawer.Draw(leftX, leftY, leftWidth, leftHeight).GetEnumerator();

        for (var currentY = 0; currentY < height; currentY++)
        for (var currentX = 0; currentX < width; currentX++)
        {
            var currentEnumerator = currentX < rightWidth ? rightEnumerator : leftEnumerator;
            currentEnumerator.MoveNext();
            yield return currentEnumerator.Current;
        }
    }
}