using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoESaque
{
    class Usuario
    {
        public int Conta { get; private set; }
        public string Nome { get; private set; }

        private double Saldo;

        static double taxa = 5.00;

        public Usuario(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0.0;

        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public void Saque(double saque)
        {
            if ((saque + taxa) > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
                
            }
            else
            {
                Saldo = (Saldo - (saque + taxa));
            }
        }

        public override string ToString()
        {
            return "Conta "
                + Conta 
                + ", Titular: "
                + Nome 
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture)
                ;
        }



    }
}
