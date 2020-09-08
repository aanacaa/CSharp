using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.ListExtensoes
{
    public static class ListExtensoes
    {
        //public static void AdicionarVarios(this List<T> lista, params T[] itens)
        //O uso da letra T é uma convenção para nomear tipo de argumento genérico.

        //ESTEÉ O MÉTODO
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        //Criamos um metodo de extensão 
        public static void TesteGenerico<T2>(this string texto)
        {
            
        }


        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);
            //idades.AdicionarVarios<int>(54, 5465, 456);
            idades.AdicionarVarios(54, 5465, 456);
            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);//Não é mais generica

            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");
            //ListExtensoes<string>.AdicionarVarios(nomes, "Lucas", "Mariana");//Não é mais generica
            nomes.AdicionarVarios("Guilherme", "Guilherme", "Guilherme");


            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();
            //Nesse caso, somos obrigados a dizer que é int, porque a string não é uma classe genérica. Se não é uma classe genérica, ela não vai trazer informações para o compilador de que o tipo genérico dessa classe é o mesmo tipo do método TesteGenerico<T2>().
            //O contrário acontece em AdicionarVarios<T>(), no qual aproveitamos que List<T> é uma classe genérica, utilizando o mesmo tipo genérico de AdicionarVarios<T>().
            
            
            //nomes.AdicionarVarios("Lucas", "Mariana");//Como vai saber o tipo ?
            //Por isso vamos remover o T do nome da classe ListExtensoes<T>

        }
    }
}
