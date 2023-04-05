using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.ConsoleApp
{
    internal class converterCelsius
    {
        public decimal Celsius;
        public decimal Fahrenheit;

        public decimal FpC()
        {
            Mensagen("\n\nInforme o valor em Fahrenheit para Celsius:");
            Fahrenheit = Convert.ToDecimal(Console.ReadLine());
            Celsius = (Fahrenheit - 32) * 5 / 9;
            Celsius = Math.Round(Celsius, 1);

            Console.WriteLine($"O resultado de conversão é: {Celsius}ºC");
            return Celsius;
        }

        public decimal CpF()
        {
            Mensagen("\n\nInforme o valor em Celsius para Fahrenheit:");
            Celsius = Convert.ToDecimal(Console.ReadLine());
            Fahrenheit = (Celsius * 9 / 5) + 32;
            Fahrenheit = Math.Round(Fahrenheit, 1);

            Console.WriteLine($"O resultado de conversão é: {Fahrenheit}ºC");
            return Fahrenheit;
        }

        public void Mensagen(string mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
