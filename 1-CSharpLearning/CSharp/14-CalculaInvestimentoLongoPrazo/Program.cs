using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 14 - Calcula investimento Longo prazo ");
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000.00;

            for (int contAno = 1; contAno <= 5; contAno++)
            {
                Console.WriteLine("Ano: " + contAno );
                for (int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Após " + contMes + " você terá: R$ " + valorInvestido);

                }
                fatorRendimento += 0.0010;
                Console.WriteLine("Após o " + contAno + " ano você terá: R$ " + valorInvestido);

            }
            Console.WriteLine("Ao termino do investimento você terá: " + valorInvestido);

            Console.ReadLine();

        }
    }
}
