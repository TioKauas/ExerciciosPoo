using Microsoft.Win32.SafeHandles;

//Exercício 6 ta junto

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Opc = new ConsoleKeyInfo();
            converterCelsius temp = new converterCelsius();

            Console.WriteLine("Qual o tipo de conversão você deseja fazer?");
            Console.WriteLine("1 - Fahrenheit para Celsius");
            Console.WriteLine("2 - Celsius para Fahrenheit");
            Console.Write(">");
            Opc = Console.ReadKey();

            switch (Opc.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    temp.FpC();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    temp.CpF();
                    break;
            }
        }
    }
}