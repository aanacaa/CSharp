using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 13 - Calcula poupança 2 ");

            double valorInvestido = 1000.00;


            for (int contMes = 0; contMes <= 12; contMes++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.0036;
                //valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contMes + " você terá: R$ " + valorInvestido);

            }

            Console.ReadLine();


        }
    }
}
