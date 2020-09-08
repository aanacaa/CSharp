using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente();
            minhaConta.saldo = 500;

            ContaCorrente outraConta = minhaConta; //O que ocorre é que minhaConta recebe 500,00 de saldo e logo depois, é criado outraConta (que é criada com tudo que tem em minhaConta), só que outraConta não é um objeto novo, já que aponta para minhaConta, com isso, já tem 500,00. Ao adicionar 1000,00 ficará com 1500,00.
            outraConta.saldo += 1000;

            Console.WriteLine(minhaConta.saldo);
            Console.ReadLine();
        }
    }
}
