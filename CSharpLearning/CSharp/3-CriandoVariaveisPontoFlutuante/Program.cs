using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3: Ponto Flutuante");

            double salario;

            salario = 8500.10;

            Console.WriteLine("Seu salário é: " + salario);

            double numero;
            numero = 15 / 2;
            Console.WriteLine("15 / 2 = " + numero);
            double numero2;
            numero2 = 15.0 / 2;
            Console.WriteLine("15 / 2 = " + numero2);

            Console.WriteLine("Tecle enter para sair..");
            Console.ReadLine(); 
        }
    }
}
