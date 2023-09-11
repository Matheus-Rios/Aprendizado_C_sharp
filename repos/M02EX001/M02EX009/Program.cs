namespace M02EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite um numero em base decimal: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n,toBase:2)} em binário");
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n,toBase:8)} em octal");
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n,toBase:16)} em Hexadecimal");
        }
    }
}