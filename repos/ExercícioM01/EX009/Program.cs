namespace EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prod1;
            float pre1;
            string prod2;
            float pre2;
            Console.Write("Produto 1: ");
            prod1 = Console.ReadLine();
            Console.Write("Preço 1: R$");
            float.TryParse(Console.ReadLine(), out pre1);
            Console.Write("Produto 2: ");
            prod2 = Console.ReadLine();
            Console.Write("Preço 2: RS");
            float.TryParse(Console.ReadLine(), out pre2);

            Console.BackgroundColor= ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Produto               Preço");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{prod1,-15}{pre1:c}");//Negativo alinha para esquerda,positivo pra direita
            Console.WriteLine($"{prod2,-15}{pre2:c}");//Negativo alinha para esquerda,positivo pra direita
            Console.ResetColor();
        }
    }
}