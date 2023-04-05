namespace Exercicio8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcularLata lata = new calcularLata();

            Console.Write("Informe a altrura da lata: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o raio da lata: ");
            double Raio = Convert.ToDouble(Console.ReadLine());

            double Volume = lata.calculoLata(Altura, Raio);

            Console.WriteLine();

            Console.WriteLine($"O volume da lata é de {Volume} cm³");
        }
    }
}