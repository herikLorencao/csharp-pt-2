using System;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "João";
            conta1.agencia = 861;
            conta1.numero = 278475;
            conta1.saldo = 300;

            ContaCorrente conta2 = new ContaCorrente();
            int idade = 20;

            conta2 = conta1;
            
            // passagem por valor
            Console.WriteLine(idade == 20);
            // passagem por referencia
            Console.WriteLine(conta2.titular);

            Console.ReadLine();
        }
    }
}
