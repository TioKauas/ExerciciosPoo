
//Exercício 6 ta junto com o exercicio 2

namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcularSalario salario = new calcularSalario();

            Console.Write("Informe o salário base: ");
            decimal SBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o total das vendas: ");
            decimal VTotal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o percentual da comissão: ");
            decimal CPercentual = Convert.ToDecimal(Console.ReadLine());

            decimal STotal = salario.calculoSalario(SBase, VTotal, CPercentual);

            Console.Write($"\nO salário total é de R$ {STotal}");
        }
    }
}