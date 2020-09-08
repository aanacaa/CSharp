using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }


        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;// Vai verificar se é um cliente, caso não seja retorna null

            if (outroCliente == null)
            {
                return false;
            }
            else
            {

                //Cliente outroCliente = (Cliente)obj;
                return CPF == outroCliente.CPF;//podemos comparar somente o identificador unico


                //Nome == outroCliente.Nome &&
                //CPF == outroCliente.CPF &&
                //Profissao == outroCliente.Profissao;
            }
        }
    }
}
