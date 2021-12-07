using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    class CalculadoraDolar
    {
        public static double IOF = 0.6;
        public static double CalcularCompraDolar(double cotacao, double dolarAComprar)
        {
            return ((cotacao + (cotacao*IOF)) * dolarAComprar);
        }
    }
}
