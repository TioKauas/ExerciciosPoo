namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumo calculo = new Consumo();
            decimal Distancia = 0;

            Console.Title = "Calcular o consumo de combustível por Km.";

            Console.Write("Informe a kilometragem inicial: ");
            decimal KmInicial = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a kilometragem Final: ");
            decimal KmFinal = Convert.ToDecimal(Console.ReadLine());

            calculo.calculoConsumo(Distancia, KmInicial, KmFinal);
        }
    }
}