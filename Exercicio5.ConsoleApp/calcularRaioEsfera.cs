using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5.ConsoleApp
{
    internal class calcularRaioEsfera
    {
        public void calculoRaio(double Raio)
        {
            decimal Volume = (4m / 3m) * (decimal)Math.PI * (decimal)Math.Pow(Raio, 3);
            Volume = Math.Round(Volume, 2);

            Console.WriteLine($"\nO Volume da esfera é de {Volume} cm");
        }
    }
}
