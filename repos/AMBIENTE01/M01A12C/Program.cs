using System.Net.Http.Headers;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            float dias = 0;
            Console.Write("Qual é o seu salário? ");
            float.TryParse(Console.ReadLine(),out sal);
            Console.WriteLine($"Você ganha {sal:c} por mês");
            Console.WriteLine("Quantos dias você trabalha por mês? ");
            float.TryParse(Console.ReadLine(), out dias);
            float media = sal / dias;
            Console.WriteLine($"Você ganha {media:c} reais por dia! ");
            Console.ReadKey();
        }
    }
}