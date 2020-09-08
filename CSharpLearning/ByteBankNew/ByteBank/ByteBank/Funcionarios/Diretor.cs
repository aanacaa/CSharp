using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor :  FuncionarioAutenticavel
    {
        //public string Senha { get; set; }
        public static int TotalDeDiretor { get; private set; }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando diretor");
            TotalDeDiretor++;
        }
        public override double GetBonificacao()
        {

            return Salario * 0.5;// Assim pega o get da base ou seja do Funcionarios

        }
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        //public bool Autenticar(string senha)
        //{
        //    return Senha == senha;
        //    //if (this.Senha == senha)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}
    }
}

