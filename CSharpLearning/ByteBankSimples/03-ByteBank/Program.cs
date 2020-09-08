using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 8656;
            contaDaGabriela.saldo = 300;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela ";
            contaDaGabrielaCosta.agencia = 123;
            contaDaGabrielaCosta.numero = 8656;
            contaDaGabrielaCosta.saldo = 900;

            Console.WriteLine("Igualdade de tipo de referência: "
                + (contaDaGabriela == contaDaGabrielaCosta));
            Console.WriteLine(contaDaGabriela);
            Console.WriteLine(contaDaGabrielaCosta);
           

            int idade = 27;
            int idadeNovamente = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == 
                idadeNovamente));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine("Igualdade de tipo de referência nova: "
              + (contaDaGabriela == contaDaGabrielaCosta));
            Console.WriteLine(contaDaGabriela);
            Console.WriteLine(contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.WriteLine(contaDaGabriela.teste);

            contaDaGabriela.saldo -= 100;
            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }
            // Não dara certo se for pensar nas mudanças
            Console.ReadLine();



        }
    }
}
