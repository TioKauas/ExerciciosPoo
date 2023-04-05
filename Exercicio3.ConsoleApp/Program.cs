namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volumeCilindro cilindro = new volumeCilindro();
            decimal raio, altura;

            Console.Write("Informe o raio do cilindro: ");
            raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a altura do cilindro: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            cilindro.calcularVolume(raio,altura);
        }
    }
}