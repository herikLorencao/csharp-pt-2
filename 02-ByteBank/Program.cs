using System;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine(contaCorrente.numero);
            Console.WriteLine(contaCorrente.agencia);
            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
