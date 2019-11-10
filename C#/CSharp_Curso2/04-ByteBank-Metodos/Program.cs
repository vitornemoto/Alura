using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();

            contaDaCamila.titular.nome = "Camila teste";
            contaDaCamila.saldo = 100;

            Console.WriteLine(contaDaCamila.saldo);
             

            Console.ReadLine();
        }
    }
}
