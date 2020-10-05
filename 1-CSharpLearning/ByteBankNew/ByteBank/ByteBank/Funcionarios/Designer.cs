using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer: Funcionario
    {
        public static int TotalDeDesigner { get; private set; }

        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer ");
            TotalDeDesigner++;
        }
        public override double GetBonificacao()
        {

            return Salario * 0.17;

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
