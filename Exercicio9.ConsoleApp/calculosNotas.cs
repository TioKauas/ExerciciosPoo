using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9.ConsoleApp
{
    internal class calculosNotas
    {
        public double calculoNota(int n)
        {
            double soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Informe a nota " + i + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());

                soma += 1 / nota;
            }

            double mediaHarmonica = n / soma;
            mediaHarmonica = Math.Round(mediaHarmonica, 2);

            return mediaHarmonica;
        }
    }
}
