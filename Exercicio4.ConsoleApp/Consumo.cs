using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.ConsoleApp
{
    internal class Consumo
    {
        public void calculoConsumo(decimal Distancia, decimal KmInicial, decimal KmFinal)
        {
            if (KmInicial < KmFinal)
            {
                Distancia = KmFinal - KmInicial;
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("O valor inicial deve ser menor que o valor final.");
                Console.Write("Pressione qualquer botão para recomeçar...");
                Console.ReadKey();

                Console.Clear();
                return;
            }

            Console.Write("Informe o combustível gasto percorrida em Litros: ");
            decimal Combustivel = Convert.ToDecimal(Console.ReadLine());

            decimal Consumo = Distancia / Combustivel;
            Consumo = Math.Round(Consumo, 2);

            Console.WriteLine();

            Console.WriteLine("Você percorreu " + Distancia + "Km");
            Console.WriteLine("Foram consumidos " + Consumo + "Km/l");
        }
    }
}
