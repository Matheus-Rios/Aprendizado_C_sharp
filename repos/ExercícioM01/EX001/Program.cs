namespace EX001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write(" MEU ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Write(" BRASIL ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write(" BRASILEIRO ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}