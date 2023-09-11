namespace M01A09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(4,49);

            Console.WriteLine("Acabei de gerar o número " +n);
            Console.ReadKey();

        }
    }
}