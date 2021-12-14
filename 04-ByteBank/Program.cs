using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Console.WriteLine(conta.saldo);
            conta.Sacar(50);
            Console.WriteLine(conta.saldo);

            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            Console.WriteLine("---------------------------");
            Console.WriteLine(conta.saldo);

            ContaCorrente contaDestino = new ContaCorrente();
            conta.Transferir(500, contaDestino);

            Console.WriteLine(conta.saldo);
            Console.WriteLine(contaDestino.saldo);

            Console.ReadLine();
        }
    }
}
