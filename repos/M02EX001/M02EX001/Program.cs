namespace M02EX001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de operadores aritméticos
            float op1 = 0;
            float op2 = 0;

            Console.Write("Digite um número: ");
            float.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite mais um número: ");
            float.TryParse(Console.ReadLine(), out op2);
            Console.WriteLine($"Calculando +{op1} = {+op1}"); // Identidade
            Console.WriteLine($"Calculando -{op1} = {-op1}"); // Negação Aritmética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); // Adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // Subtração
            Console.WriteLine($"Calculando {op1} X {op2} = {op1 * op2}"); // Multiplicação
            Console.WriteLine($"Calculando {op1} / {op2} = {(int)op1 / op2} (divisão inteira)");//Divisão inteira
            Console.WriteLine($"Calculando {op1} / {op2} = {op1 / op2}");
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}"); // Resto da Divisão
            Console.ReadKey();
        }
    }
}