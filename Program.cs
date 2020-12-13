using System;
using System.Globalization;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            

            Console.Write("Digite por favor o numero da conta: ");
            conta.Numero = int.Parse(Console.ReadLine());
            Console.Write("Precisamos verificar o Titular, insira seu nome completo: ");
            conta.NomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (S / N): ");
            string Haveradeposito = Console.ReadLine();
                       
            switch (Haveradeposito)
            {
                case "S" : 
                            Console.WriteLine("Digite o valor a ser depositado");
                            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            conta.EfetuarDeposito(valorDepositado);
                            break;
                case "N":
                            System.Console.WriteLine("Ótimo, não haverá deposito inicial!");
                            break;
                default: Console.WriteLine("operação inválida"); break;
            }
            

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(conta.ToString());
            System.Console.WriteLine();
            System.Console.Write("Entre com um valor para depósito: "); 
            double SegundoDeposito = double.Parse(Console.ReadLine());
            conta.EfetuarNovoDeposito(SegundoDeposito);

            System.Console.WriteLine("Dados da conta atualizado: ");
            System.Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: {2}", conta.Numero, conta.NomeTitular, conta.SaldoRestante.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine();

            System.Console.WriteLine("Deseja realizar um saque (S/N) ?");
            string RealizarSaque = Console.ReadLine();

            switch(RealizarSaque)
            {
                case "S":
                            System.Console.WriteLine("Por favor, informe  valor para saque!");
                            double ValorSaque = double.Parse(Console.ReadLine());
                            conta.Desconto(ValorSaque);
                            System.Console.WriteLine("Dados Atualizados: ");
                            System.Console.WriteLine("conta: {0}, Titular: {1}, Saldo: {2}.", conta.Numero, conta.NomeTitular, conta.SaldoDescontado);
                            break;
                case "N":

                            System.Console.WriteLine("Muito Obrigado por utilizar nossos serviços!!!");
                            break;
            }

        }
    }
}
