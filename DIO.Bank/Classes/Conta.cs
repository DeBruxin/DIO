namespace DIO.Bank
{
    public class Conta
    {   
        // Atributos
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        // Construtor
        public Conta {TipoConta TipoConta, string Nome, double Saldo, double Credito} {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }
    }
}