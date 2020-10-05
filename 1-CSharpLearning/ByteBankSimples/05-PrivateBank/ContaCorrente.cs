using System.Diagnostics.Eventing.Reader;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        //aqui é o else
        this.saldo -= valor;
        return true;
     
    }
    // quando retorna valor chamamos de função
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        //aqui é o else
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        //contaDestino.saldo += valor
        return true;
        
    }

}
//quando não retorna um valor chamamos de método

//Uma classe define os membros e a estrutura 
//que os objetos deste tipo de 
//classe devem seguir.
//Uma classe é a especificação para a criação 
//de um objeto na memória do computador.
