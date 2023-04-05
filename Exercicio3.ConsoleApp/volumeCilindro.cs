using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.ConsoleApp
{
    internal class volumeCilindro
    {
        public void calcularVolume(decimal raio, decimal altura)
        {
            decimal Volume = (decimal)(Math.PI * Math.Pow((double)raio, 2) * (double)altura);
            Volume = Math.Round(Volume,2);

            Console.WriteLine($"\nO volume do cilindro é de {Volume}");
        }
    }
}
