using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            new ContaCorrente(1234231, 1234);
            new ContaCorrente(1223545, 1234);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.ReadLine();
        }
    }
}
