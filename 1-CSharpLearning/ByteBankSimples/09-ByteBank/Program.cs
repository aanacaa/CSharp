using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 5644555);
            Cliente cliente = new Cliente("Guilherme", "465464565156");
            conta.Titular = cliente;
            Console.WriteLine(conta.Agencia + "-" + conta.Numero + " - " + conta.Titular.Nome);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contaGabi = new ContaCorrente(867, 5644555);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(ContaCorrente.TaxaOperacao);


            Console.ReadLine();
        }
    }
}
