using System;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Ana";
            cliente.CPF = "123.325.256-12";
            cliente.Profissao = "Desenvolvedor C#";

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Titular = cliente;

            Console.WriteLine(contaCorrente.Titular.Nome);
            Console.ReadLine();
        }
    }
}
