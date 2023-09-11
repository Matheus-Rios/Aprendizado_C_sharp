namespace EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n;
            int inteiro;
            int arredondado;
            Console.Write("Digite um número Real: ");
            float.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Você digitou o valor {n}");
            inteiro = (int)n;
            Console.WriteLine($"A parte inteira do numero é {inteiro}");
            arredondado = Convert.ToInt32(n);
            Console.WriteLine($"Arredondando, temos o numero {arredondado}");
        }
    }
}