namespace M02EX006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0f;
            float n2 = 0f;
            //Entrada de dados
            Console.Write("Primeira nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);
            //Cálculo da média e situações 
            float media = (n1 + n2) / 2;
            bool sit01 = media >= 0.0 && media< 4.0;
            bool sit02 = media >= 4.0 && media < 7.0;
            bool sit03 = media >= 7.0 && media <= 10.0;
            //Mostrando Resultados
            Console.WriteLine($"A média do aluno foi {media:f1}");
            Console.WriteLine($"Aluno está reprovado? {sit01}");
            Console.WriteLine($"Aluno está em recuperação? {sit02}");
            Console.WriteLine($"Aluno está aprovado? {sit03}");

        }
    }
}