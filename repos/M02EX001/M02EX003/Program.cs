namespace M02EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0f;
            float nota2 = 0f;

            Console.Write("Digite um numero: ");
            float.TryParse(Console.ReadLine(),out nota1);
            Console.Write("Digite outro numero: ");
            float.TryParse(Console.ReadLine(),out nota2);
            float media = (nota1 + nota2) / 2;
            Console.WriteLine($"As notas registradas foram {nota1:f1} e {nota2:f1}");
            Console.WriteLine($"A media do aluno foi {media:F1}");
        }
    }
}