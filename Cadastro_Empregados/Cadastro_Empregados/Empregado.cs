using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Empregados
{
    class Empregado
    {
        public int Id;
        public string Nome;
        public double Salario;

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario = (Salario + (Salario * porcentagem));
        }
    }
}
