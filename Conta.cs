public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor <= Saldo && valor > 0.0) {
            throw new ArgumentException("O valor não pode ser sacado, saldo insuficiente!");
        }
        Saldo = Saldo - valor;
    }

     public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        if(Saldo >= valor && valor > 0.0)
        {
            Saldo = Saldo - valor;
            conta.Depositar(valor);

        } else 
        {
            throw new ArgumentException("Este valor não pode ser transferido");
        }

    }
}