namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcularRaioEsfera Esfera = new calcularRaioEsfera();

            Console.Write("Informe o raio da esfera: ");
            double Raio = Convert.ToDouble(Console.ReadLine());

            Esfera.calculoRaio(Raio);
        }
    }
}