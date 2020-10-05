using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado();
            teste.MetodoInterno();
            //teste.MetodoProtegido()
        }
    }
    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste" ou seja na Solution inteira
        }
        private void MetodoPrivado()
        {
            //Visível apenas na classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            //Visível apenas na classe "ModificadoresTeste" e derivados
        }
        internal void MetodoInterno()
        {
            //Visível apenas para o projeto ByteBank.Modelos
        }

        //internal protected é considerado um modificador de acesso único
    }
}