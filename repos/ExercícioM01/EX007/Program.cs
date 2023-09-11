namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fim;
            string ação;
            string mensagem;
            Console.WriteLine("SORTEADOR DE NÚMEROS");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out inicio);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);
            Random random = new Random();
            int n = random.Next(inicio, fim + 1);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sorteando...");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0,5);
            Console.WriteLine($"O valor sorteado entre os números {inicio} e {fim} foi {n}");
            Console.ReadKey();
        }
    }
}