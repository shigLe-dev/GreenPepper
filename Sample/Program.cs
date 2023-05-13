using ShigLe.TUITools;
using ShigLe.TUITools.Drawers;

var greenPepper = new GreenPepper();

while (true)
{
    greenPepper.Draw(new Text("aaa"));
    Thread.Sleep(1 / 60);
}