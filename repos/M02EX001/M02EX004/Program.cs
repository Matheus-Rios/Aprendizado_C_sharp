using System.Text;

namespace M02EX004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            
            //Entrada de dados

            Console.Write("Digite um numero: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Digite outro numero: ");
            int.TryParse(Console.ReadLine(), out n2);

            //Saida de dados

            Console.WriteLine($"{n1} == {n2} ? {n1==n2}");
            Console.WriteLine($"{n1} != {n2} ? {n1 !=n2}");
            Console.WriteLine($"{n1} > {n2} ? {n1 >n2}");
            Console.WriteLine($"{n1} < {n2} ? {n1 < n2}");
            Console.WriteLine($"{n1} >= {n2} ? {n1 >= n2}");
            Console.WriteLine($"{n1} <= {n2} ? {n1 <= n2}");
            Console.WriteLine($"{n1} é inteiro ? {n1 is int}");

            
        }
    }
}