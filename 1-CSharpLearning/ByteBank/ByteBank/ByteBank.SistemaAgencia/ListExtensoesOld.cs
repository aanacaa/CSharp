using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoesOld
    {
        //public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
       public static void AdicionarVariosOld(this List<int> listaDeInteiros, params int[] itens)

        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
