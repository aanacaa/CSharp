using System.Diagnostics.Eventing.Reader;
//using _07_PrivateBank;

namespace _07_ByteBank // ao colocar o name space não precisa mais do using
{
    public class ContaCorrente
    {
        //public _07_PrivateBank.Cliente titular;

        //Não precisa fazer o codigo abaixo
        //private Cliente _titular;
        //public Cliente Titular
        //{
        //    get
        //    {
        //        return _titular;
        //    }
        //    set
        //    {
        //        _titular = value;
        //    }
        //}
        //Maneira mais simples:
        public Cliente Titular { get; set; }
        public int Agencia { get; set; } //public int agencia;
        public int Numero { get; set; } //public int numero;


        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value; // value seria o saldo que entra
                }

            }
        }


        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        //public void SetSaldo(double saldo)
        //{ 
        //    if(saldo <0)
        //    {
        //        return;
        //        //deveria lançar um erro 
        //    }
        //    else
        //    {
        //        this.saldo = saldo;//Aquui foi colocardo o this pos entra em conflito com a nova variavel saldo declarada somente nesse método
        //    }
        //}
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            //aqui é o else
            _saldo -= valor;
            return true;

        }
        // quando retorna valor chamamos de função
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            //aqui é o else
            _saldo -= valor;
            contaDestino.Depositar(valor);
            //contaDestino.saldo += valor
            return true;

        }

    }
}

//quando não retorna um valor chamamos de método

//Uma classe define os membros e a estrutura 
//que os objetos deste tipo de 
//classe devem seguir.
//Uma classe é a especificação para a criação 
//de um objeto na memória do computador.
