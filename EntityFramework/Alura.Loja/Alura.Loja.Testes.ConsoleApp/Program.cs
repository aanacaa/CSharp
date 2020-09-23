using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();
                foreach(var p in produtos)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("-------Estado------------");

                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.State);
                }
                Console.WriteLine("------Mudança-------------");

                var p1 = produtos.First();
                p1.Nome = "HP ";
                //contexto.SaveChanges();


                Console.WriteLine("--------Estado-----------");
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.State);
                }
                Console.WriteLine("------Novo valor-------------");

                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("-------------------");

                



                //Console.WriteLine("-------------------");

                //foreach (var p in produtos)
                //{
                //    Console.WriteLine(p);
                //}
            }
            Console.ReadLine();

        }
     
    }
}
