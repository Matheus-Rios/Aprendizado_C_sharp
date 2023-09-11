namespace M02EX005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool q = false;

            Console.WriteLine($"não {p} = {!p}");//Operador lógico NÂO 
            Console.WriteLine($"{p} e {q} = {p && q}");//Operador lógico E
            Console.WriteLine($"{p} ou {q} = {p || q}");//Operador lógico OU
        }
    }
}