﻿using ShigLe.TUITools;
using ShigLe.TUITools.Drawers;
using ShigLe.TUITools.Drawers.Containers;

var greenPepper = new GreenPepper();

while (true)
{
    greenPepper.Draw(new HorizontalContainer(
            new Text("ccccccc"),
            new VerticalContainer(
                new Text("aaaa"),
                new Text("bbbb")
            )
        )
    );
    Thread.Sleep(1 / 60);
}