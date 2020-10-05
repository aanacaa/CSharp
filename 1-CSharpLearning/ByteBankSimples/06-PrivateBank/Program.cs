using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   //melhor forma:
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Dev";
            //gabriela.cpf = "123.456.789-89";
            

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 56565;

            //Comentei o bloco para outra forma
            //conta.titular.nome = "Gabriela Costa";
            //Console.WriteLine(gabriela.nome);
            //Console.WriteLine(conta.titular.nome);

            //outra forma instanciando direto:
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Desenvolvedora C#";
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
