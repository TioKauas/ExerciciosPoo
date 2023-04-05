using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1.ConsoleApp
{
    internal class caixaRetangular
    {
        public int comprimento;
        public int largura;
        public int altura;

        public decimal calcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}
