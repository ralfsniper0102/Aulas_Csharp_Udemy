using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Params
{
    class Calculadora
    {
        static public double Soma(params double[] valores)
        {
            double soma = 0.0;

            for (int i = 0; i<valores.Length; i++ )
            {
                soma = soma + valores[i];
            }

            return soma;


        }
    }
}
