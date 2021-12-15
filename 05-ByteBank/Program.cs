using System;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            ContaCorrente contaCorrente = new ContaCorrente();

            // A referência será a mesma
            contaCorrente.titular = cliente;
            contaCorrente.titular.nome = "Maria";

            Console.WriteLine(cliente.nome);
            Console.WriteLine(contaCorrente.titular.nome);

            Console.ReadLine();
        }
    }
}
