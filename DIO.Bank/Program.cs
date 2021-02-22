using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {   // Uso provisorio para "guardar" as novas contas criadas.
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "0"){
                switch (opcaoUsuario) {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "9":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();

        // Criação das opções do menu.
            static string ObterOpcaoUsuario() {
            Console.WriteLine();
            Console.WriteLine("BPQ Bank!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Realizar transferência");
            Console.WriteLine("4 - Realizar saque");
            Console.WriteLine("5 - Realizar depósito");
            Console.WriteLine("9 - Limpar tela");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        }

        // Método para listar as contas existentes
        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0){
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++){
                Conta conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        // Método para criação de novas contas
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para PF - Pessoa Fisica e 2 para PJ - Pessoa Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente:");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        nome: entradaNome,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito);

            listContas.Add(novaConta);
        }
        //Método para realizar o depósito.
        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }
        // Método para realizar o saque.
           private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }
        // Método para realizar a transferência.
        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorDeposito, listContas[indiceContaDestino]);
        }
    }   
}
