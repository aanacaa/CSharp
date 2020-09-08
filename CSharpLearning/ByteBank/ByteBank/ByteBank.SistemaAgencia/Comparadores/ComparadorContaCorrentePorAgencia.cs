using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {

            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            return x.Agencia.CompareTo(y.Agencia);
            //Dessa forma, resumimos o que esperamos:

            //0 se x.Agencia for igual a y.Agencia;
            //-1 se x.Agencia for menor que y.Agencia;
            //1 se y.Agencia for menor que x.Agencia.

            // Nossas comparações de números inteiros é equivalente
            // ao que já existe no tipo INT
            // return x.Agencia.CompareTo(y.Agencia);


            //if (x.Agencia < y.Agencia)
            //{
            //    return -1; //x fica a frente de y
            //}

            //if (x.Agencia == y.Agencia)
            //{
            //    return 0; //equivalentes

            //}

            //return 1; // y fica na frente de x
        }
    }
}
