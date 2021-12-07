using System;
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

    }
}
