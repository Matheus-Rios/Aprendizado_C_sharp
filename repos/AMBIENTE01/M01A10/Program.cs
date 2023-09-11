namespace M01A10
{
    internal class Program
    {
        static void Main(string[] args)
        {   int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine("A data atual é dia "+dia+" do mês "+mes+" do ano "+ano );
            Console.ReadKey();

            int hora=DateTime.Now.Hour;
            int min=DateTime.Now.Minute;
            int seg=DateTime.Now.Second;
            Console.WriteLine("A hora atual é de "+hora+" horas "+min+" minutos "+seg+" segundos.");
            Console.ReadKey();
        }
    }
}