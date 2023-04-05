using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7.ConsoleApp
{
    internal class calcularSalario
    {
        public decimal calculoSalario(decimal VTotal, decimal CPercentual, decimal SBase)
        {
            decimal STotal = (VTotal * (CPercentual / 100)) + SBase;

            return STotal;
        }
    }
}
