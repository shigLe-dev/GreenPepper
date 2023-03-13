using System.Text;
using Kodnix.Character;
using GreenPepper;

Console.OutputEncoding = Encoding.UTF8;


Console.Write(text.Build(Console.WindowWidth, 1));

while (true)
{
    Console.WriteLine(EastAsianWidth.GetLength(Console.ReadKey().KeyChar));
}