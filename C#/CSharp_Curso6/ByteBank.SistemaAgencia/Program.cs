using System;
using Humanizer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ContaCorrente conta = new ContaCorrente(374,3627365);
            Console.WriteLine(conta.Saldo);*/

            //teste datetime para pacote NuGet
            DateTime dataFimPagamento = new DateTime(2020, 9, 11);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
