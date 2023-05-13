namespace ShigLe.TUITools.Drawers.Containers;

public class HorizontalContainer : IDrawer
{
    private readonly IDrawer leftDrawer;
    private readonly IDrawer rightDrawer;

    public HorizontalContainer(IDrawer leftDrawer, IDrawer rightDrawer)
    {
        this.leftDrawer = leftDrawer;
        this.rightDrawer = rightDrawer;
    }

    public IEnumerable<char> Draw(int x, int y, int width, int height)
    {
        var leftX = x;
        var leftY = y;
        var leftWidth = width / 2;
        var leftHeight = height;

        var rightX = x + leftWidth;
        var rightY = y;
        var rightWidth = width - leftWidth;
        var rightHeight = height;

        var leftEnumerator = leftDrawer.Draw(leftX, leftY, leftWidth, leftHeight).GetEnumerator();
        var rightEnumerator = rightDrawer.Draw(rightX, rightY, rightWidth, rightHeight).GetEnumerator();

        for (var currentY = 0; currentY < height; currentY++)
        for (var currentX = 0; currentX < width; currentX++)
        {
            var currentEnumerator = currentX < leftWidth ? leftEnumerator : rightEnumerator;
            currentEnumerator.MoveNext();
            yield return currentEnumerator.Current;
        }
    }
}