using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 8500.10;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Salário em inteiro: " + salarioEmInteiro);
            //O int é um tipo de variável que suporta valores até 32 bits
            // O long é uma variável de 64 bits
            //O short é um tipo de variável de 16 bits

            long numero_gigante = 130000000000000;
            Console.WriteLine(numero_gigante);

            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.50f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
