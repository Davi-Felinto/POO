namespace WebApiExemplosPOOESW.Model
{
    public class ContaBancaria
    {

        private int numero;
        private string titular;
        private double saldo = 10000;

        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; private set => saldo = value; }

        public string RetornarDadosClientes()
        {
            return $"DADOS DA CONTA BANCARIA\r\n" +
                   $"NUMERO DA CONTA: {numero}\r\n" +
                   $"NOME DO TITULAR: {titular}" +
                   $"SALDO DA CONTA: R${saldo}";
        }

        public void Depositar(double ValorDeposito)
        {
            saldo += ValorDeposito;
        }

        public void Sacar(double ValorSaque)
        {
            saldo -= ValorSaque;
        }

        

    }
}
