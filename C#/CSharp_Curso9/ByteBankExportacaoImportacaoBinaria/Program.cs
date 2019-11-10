using System;
using System.IO;
using System.Text;

namespace ByteBankExportacaoImportacaoBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //EscreverArquivoBinario();
            LerArquivoBinario();
            Console.ReadLine();
        }

        static void EscreverArquivoBinario()
        {
            var caminhoArquivo = "testeBinario.txt";
            using (var fs = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); // Número da Agência
                escritor.Write(546544); // Número da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Gustavo Braga");
            }
        }

        static void LerArquivoBinario()
        {
            File.readalltex
            var caminhoArquivo = "testeBinario.txt";
            using (var fs = new FileStream(caminhoArquivo, FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }


    }
}
