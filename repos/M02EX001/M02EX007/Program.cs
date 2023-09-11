namespace M02EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            float altura = 0;
            Console.Write("Qual a sua altura em metros? ");
            //Verificação de status
            float.TryParse(Console.ReadLine(), out altura);
            string comparador = (altura <=170)?"baixa":"alta";
            Console.WriteLine($"Alguem com {altura:f2}m de altura é considerado uma pessoa {comparador}");
        }
    }
}