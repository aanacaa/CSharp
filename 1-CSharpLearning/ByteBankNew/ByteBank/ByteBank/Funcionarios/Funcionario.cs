using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // Diz que é abstrato pois não da as informacoes diretas assim nao pode ser mais instanciado 
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando funcionário");
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }
       
        // Classes abaixo estão declaradas no Funcionarios pois todos os funcionarios tem essas ações
        // Com o virtual pode sobreescrever SE colocar o override na filha 
        // Com o abstract é OBRIGA a sobreescrever e de escrever a classe na filha, com isso o conteudo da classe foi removido daqui
        public abstract void AumentarSalario();
        //{
        //Salario = Salario * 1.1; //Aumenta 10 %
        //Salario *= 1.1;
        //}
        public abstract double GetBonificacao();
        //{return Salario * 0.1;}
    }
}
