using System;
using System.IO;
using System.Text;

namespace ByteBankExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //CriarArquivo();
            //CriarArquivoComStreamWriter();
            TestaEscrita();
            Console.ReadLine();

        }

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComStreamWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using ( var escirtor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escirtor.Write("456, 65465, 456.0, Pedro");

            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush();//grava no arquivo(HD Fisico) o que estava no buffer da memoria RAM
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
            {

            }
        }

    }
}
