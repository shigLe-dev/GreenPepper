namespace ShigLe.TUITools.Drawers;

public class Text : IDrawer
{
    public readonly string text;

    public Text(string text)
    {
        this.text = text;
    }

    public IEnumerable<char> Draw(int x, int y, int width, int height)
    {
        for (var currentY = 0; currentY < height; currentY++)
        for (var currentX = 0; currentX < width; currentX++)
        {
            var index = currentY * width + currentX;
            var returnChar = ' ';

            if (text.Length > index) returnChar = text[index];

            yield return returnChar;
        }
    }
}