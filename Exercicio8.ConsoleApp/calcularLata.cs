using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8.ConsoleApp
{
    internal class calcularLata
    {
        public double calculoLata(double Altura, double Raio)
        {
            double Volume = Altura * Math.PI * Math.Pow(Raio, 2);
            Volume = Math.Round(Volume, 2);

            return Volume;
        }
    }
}
