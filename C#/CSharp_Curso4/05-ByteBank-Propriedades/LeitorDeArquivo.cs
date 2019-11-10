using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _05_ByteBank_Propriedades
{
    public class LeitorDeArquivo:IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProxima()
        {
            Console.WriteLine("Lendo linha...");

            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }


    }
}
