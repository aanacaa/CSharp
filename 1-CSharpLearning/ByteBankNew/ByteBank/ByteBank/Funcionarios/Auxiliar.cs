using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public static int TotalDeAuxiliar { get; private set; }

        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar ");
            TotalDeAuxiliar++;
        }
        public override double GetBonificacao()
        {

            return Salario * 0.2;

        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
