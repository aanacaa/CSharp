using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            //conta.SetSaldo(-10);
            //Console.WriteLine(conta.GetSaldo());

            cliente.Nome = "Guilherme";
            cliente.CPF = "200.222.222-55";
            cliente.Profissao = "Dev";
            
            conta.Titular = cliente;
            conta.Saldo = -10;


            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
