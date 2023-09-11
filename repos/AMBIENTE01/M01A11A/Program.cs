namespace M01A11A
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int dia =DateTime.Now.Day;
            int mes =DateTime.Now.Month;
            int ano =DateTime.Now.Year;
            Console.Write("Hoje é dia ");
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mês ");
            Thread.Sleep(1000);
            Console.WriteLine(mes);
            Thread.Sleep(2000);

        }
    }
}