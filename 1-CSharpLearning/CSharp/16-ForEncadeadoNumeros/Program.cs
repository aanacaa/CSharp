using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ForEncadeadoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            //12
            //123
            //1234
            //12345
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
