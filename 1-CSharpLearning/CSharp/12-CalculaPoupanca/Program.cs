using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula poupança");

            double valorInvestido = 1000.00;
            int contMes = 1;
            //0,36% = 0,0036

            while (contMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contMes + " você terá: R$ " + valorInvestido);
                //contMes += 1;
                contMes++;
            }

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Apos um mês você terá: " + valorInvestido);

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Apos dois meses você terá: " + valorInvestido);

            Console.ReadLine();

        }
    }
}
