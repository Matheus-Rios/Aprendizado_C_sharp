namespace M01A12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Tudo bem?");

            int dia=DateTime.Now.Day;
            int mes=DateTime.Now.Month;
            int ano=DateTime.Now.Year;
            Console.WriteLine($"Hoje é {dia} do mês {mes} do ano {ano}");
            Console.ReadKey();
        }
    }
}