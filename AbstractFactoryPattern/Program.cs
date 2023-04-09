#define MacOS

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Abstract Factory pattern\n");
#if MacOS
            MacFactory factory = new MacFactory();
#else
            WinFactory factory = new WinFactory();
#endif
            GUI ui = new GUI(factory);
            ui.CreateUI();
            ui.Paint();
        }
    }
}