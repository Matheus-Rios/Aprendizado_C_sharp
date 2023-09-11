namespace M02EX002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            //Entrada de dados:
            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine($"Divisão inteira {n1} / {n2} = {(int)n1/(int)n2:D}");
            Console.WriteLine($"Divisão real {n1} / {n2} = {(float)n1/(float)n2:f2}");
            Console.ReadKey();

        }
    }
}