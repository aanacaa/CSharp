using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
        //Todos os membros de uma interface são publicos
        //Ela é um contrato onde quem assina se responsabiliza por implementar esses métodos (cumprir o contrato)
        //interfaces não podem conter campos!
        //Um dos grandes benefícios do uso de interfaces é que podemos implementar várias interfaces simultaneamente
    }
}
