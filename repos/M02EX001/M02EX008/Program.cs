namespace M02EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Digite um numero inteiro: ");
            int.TryParse(Console.ReadLine(), out numero);
            //int verificar = numero % 2;
            //string verificador = (verificar != 0)?"Impar": "Par";
            Console.WriteLine($"O número {numero} é {((numero%2==0)?"Par":"Impar")}!");
        }
    }
}