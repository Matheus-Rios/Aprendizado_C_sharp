namespace EX005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort ano;
            int idade;
            Console.Write("Em que ano você nasceu? ");
            ushort.TryParse(Console.ReadLine(), out ano);
            idade =  DateTime.Now.Year-ano;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Estamos atualmente no ano de {DateTime.Now.Year}");
            Console.WriteLine($"Se você nasceu em {ano}, você tem {idade} anos");
        }
    }
}