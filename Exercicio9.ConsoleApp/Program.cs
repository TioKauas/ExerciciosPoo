namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculosNotas mediaNotas = new calculosNotas();

            Console.Write("Informe o número de notas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double mediaHarmonica = mediaNotas.calculoNota(n);

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica}");
        }
    }
}