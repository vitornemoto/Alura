using System;
using System.IO;

namespace _05_ByteBank_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {

            //curso 4

            /* try
             {
                 ContaCorrente conta = new ContaCorrente(15, 255);
                 ContaCorrente conta2 = new ContaCorrente(16, 256);

                 conta.Transferir(10000, conta2);
                 //conta.Depositar(100);
                 conta.Sacar(-500);
                 //Metodo();
             }
             catch(ArgumentException e)
             {
                 Console.WriteLine(e.Message);
                 Console.WriteLine(e.ParamName);
             }
             catch (DivideByZeroException e)
             {
                 Console.WriteLine("Não é possível divisão por zero.");
             }
             catch(OperacaoFinanceiraException e)
             {
                 Console.WriteLine(e.Message);
                 Console.WriteLine(e.StackTrace);

                 Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                 Console.WriteLine(e.InnerException.Message);
                 Console.WriteLine(e.InnerException.StackTrace);

             }

             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
                 Console.WriteLine(e.StackTrace);
             }
            */

            // teste para leitor de arquivo, bloco finally e using

            CarregarContas();


            Console.ReadLine();

        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                ContaCorrente conta = null;
                // Console.WriteLine(conta.Saldo);
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }

        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        private static void CarregarContas()
        {
            // alterado para o bloco finally
            /*LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");
                leitor.LerProxima();
                leitor.LerProxima();
                leitor.LerProxima();
            }
            catch(IOException e)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }

            }*/


            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProxima();
                leitor.LerProxima();
                leitor.LerProxima();
            }

        }
    }
}
