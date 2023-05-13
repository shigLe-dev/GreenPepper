namespace ShigLe.TUITools.Drawers.Containers;

public class VerticalContainer : IDrawer
{
    private readonly IDrawer lowerDrawer;
    private readonly IDrawer upperDrawer;

    public VerticalContainer(IDrawer upperDrawer, IDrawer lowerDrawer)
    {
        this.upperDrawer = upperDrawer;
        this.lowerDrawer = lowerDrawer;
    }

    public IEnumerable<char> Draw(int x, int y, int width, int height)
    {
        var upperX = x;
        var upperY = y;
        var upperWidth = width;
        var upperHeight = height / 2;

        var lowerX = x;
        var lowerY = y + upperHeight;
        var lowerWidth = width;
        var lowerHeight = height - upperHeight;

        var upperEnumerator = upperDrawer.Draw(upperX, upperY, upperWidth, upperHeight).GetEnumerator();
        var lowerEnumerator = lowerDrawer.Draw(lowerX, lowerY, lowerWidth, lowerHeight).GetEnumerator();

        for (var currentY = 0; currentY < height; currentY++)
        for (var currentX = 0; currentX < width; currentX++)
        {
            var currentEnumerator = currentY < upperHeight ? upperEnumerator : lowerEnumerator;
            currentEnumerator.MoveNext();
            yield return currentEnumerator.Current;
        }
    }
}