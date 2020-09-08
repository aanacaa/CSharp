using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.Read();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            Console.WriteLine("-----");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            Console.WriteLine("-----");
            camila.Nome = "Camila";
            camila.Senha = "456";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            Console.WriteLine("-----");
            igor.Nome = "Igor";
            //igor.Senha = "456"; // não pode usar pq nao é autenticavel

            ParceiroComercial parceiro = new ParceiroComercial();
            Console.WriteLine("-----");
            parceiro.Senha = "123153";


            sistemaInterno.Logar(roberta, "123");

            sistemaInterno.Logar(camila, "456");
            sistemaInterno.Logar(parceiro, "123");

            //sistemaInterno.Logar(igor, "abc");


        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //Funcionario  pedro = new Designer("833.222.048-39");//Pode ser assim tambem

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);


            Console.WriteLine("Total de bonificação do mês"+ 
                gerenciadorBonificacao.GetTotalBonificacao());

        }

    }
}
