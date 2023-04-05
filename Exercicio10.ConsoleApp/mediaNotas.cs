using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    internal class mediaNotas
    {
        public double calculoMedia(double n1, double n2)
        {
            double mediaHarmonica = 2 / ((1 / n1) + (1 / n2));
            mediaHarmonica = Math.Round(mediaHarmonica, 2);

            return mediaHarmonica;
        }
    }
}
