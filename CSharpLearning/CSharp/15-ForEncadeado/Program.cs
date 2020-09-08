using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            //Usando o Break
            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna < 10; contColuna++)
                {
                    Console.Write("*");
                    if(contColuna >= contLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            //Outra forma
            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
