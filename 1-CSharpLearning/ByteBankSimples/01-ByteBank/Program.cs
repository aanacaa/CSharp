using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 564;
            contaDaGabriela.saldo = 500.3;

            Console.WriteLine("Nome: "+ contaDaGabriela.titular);
            Console.WriteLine("Agência: "+ contaDaGabriela.agencia);
            Console.WriteLine("Número da Conta"+ contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$ "+ contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: R$ " + contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
