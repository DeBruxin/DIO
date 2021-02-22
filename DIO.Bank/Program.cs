using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, "Bruno Pinheiro", 0, 0);
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
