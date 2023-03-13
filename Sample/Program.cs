using System.Text;
using GreenPepper;

Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.Write(new Window(Console.WindowWidth, Console.WindowHeight).Build().Build(Console.WindowWidth, Console.WindowHeight));
    Console.ReadKey(true);
}