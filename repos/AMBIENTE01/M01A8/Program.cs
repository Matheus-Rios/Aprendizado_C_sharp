namespace M01A8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer em te conhecer, " + nome + "!");
            Console.ReadKey();

        }
    }
}