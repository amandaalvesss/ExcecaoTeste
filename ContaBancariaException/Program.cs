using System;
using ContaBancariaException.Entidades;
using ContaBancariaException.Entidades.Exception;

namespace ContaBancariaException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Conta conta = new Conta();
                Console.WriteLine("Digite os dados da conta");
                Console.Write("Numero da conta: ");
                conta.Numero = int.Parse(Console.ReadLine());
                Console.Write("Nome do titular: ");
                conta.Titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                conta.LimiteSaque = double.Parse(Console.ReadLine());

                Console.WriteLine(conta);

                Console.WriteLine("Digite o valor do deposito: ");
                double quantidade = double.Parse(Console.ReadLine());
                conta.Deposito(quantidade);

                Console.WriteLine(conta);

                Console.WriteLine("Digite o valor do saque: ");
                double quantidadeSaque = double.Parse(Console.ReadLine());
                conta.Saque(quantidadeSaque);

                Console.WriteLine(conta);


            } catch (ExcecaoDominio e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}