namespace ShigLe.TUITools.Drawers;

public class Text : IDrawer, IDrawable
{
    public readonly string text;

    public Text(string text)
    {
        this.text = text;
    }

    public IDrawer GetDrawer()
    {
        return this;
    }

    public BoxConstraints GetConstraints(Size size)
    {
        return new BoxConstraints(text.);
    }

    public IEnumerable<char> Draw(Position position, Size size)
    {
        for (var currentY = 0; currentY < size.height; currentY++)
        for (var currentX = 0; currentX < size.width; currentX++)
        {
            var index = currentY * size.width + currentX;
            var returnChar = ' ';

            if (text.Length > index) returnChar = text[index];

            yield return returnChar;
        }
    }
}