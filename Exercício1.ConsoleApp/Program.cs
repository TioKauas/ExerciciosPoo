namespace Exercício1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            caixaRetangular caixa = new caixaRetangular();

            caixa.comprimento = 20;
            caixa.largura = 10;
            caixa.altura = 30;

            Console.WriteLine($"O volume da caixa é: {caixa.calcularVolume()}");
        }
    }
}