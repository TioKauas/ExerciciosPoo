namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mediaNotas Notas = new mediaNotas();

            Console.Write("Informe e nota da primeira prova: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe e nota da segunda prova: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double mediaHarmonica = Notas.calculoMedia(n1, n2);

            Console.WriteLine("A média é de " + mediaHarmonica);
        }
    }
}