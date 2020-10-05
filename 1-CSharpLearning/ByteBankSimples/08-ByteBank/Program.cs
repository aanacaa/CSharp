using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ContaCorrente.ObterTotalDeContasCriadas());
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            //ContaCorrente.TotalDeContasCriadas = 20; //Não pode setar mais pois é privado
            //ContaCorrente.TotalDeContasCriadas = 1000;//Isso nao pode 
            ContaCorrente conta = new ContaCorrente(867, 5644555);
            Console.WriteLine(conta.Agencia + "-" + conta.Numero);
            //ContaCorrente.TotalDeContasCriadas++;// Não é de responsabilidade do programador
            //Console.WriteLine(ContaCorrente.ObterTotalDeContasCriadas());
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaGabi = new ContaCorrente(867, 5644555);
            //ContaCorrente.TotalDeContasCriadas++;// Não é de responsabilidade do programador
            // Console.WriteLine(ContaCorrente.ObterTotalDeContasCriadas());
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();
        }
    }
}
