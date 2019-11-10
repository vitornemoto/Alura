using System;

namespace _05_ByteBank_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(33, 38596);
            ContaCorrente conta1 = new ContaCorrente(32, 38596);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
