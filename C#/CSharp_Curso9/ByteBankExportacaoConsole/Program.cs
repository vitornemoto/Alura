using System;
using System.IO;

namespace ByteBankExportacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //LerConsole();
            //LerConsoleSimplificado();
            UtilizarClasseFile();
            Console.ReadLine();
        }

        static void LerConsole()
        {
            var caminhoArquivo = "testeConsole.txt";
            using (var fluxoDeEntrada = Console.OpenStandardInput())
                using (var fs = new FileStream(caminhoArquivo, FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesLidos);

                    fs.Flush();

                    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                }
            }
        }
        static void LerConsoleSimplificado()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}");
        }

        static void UtilizarClasseFile()
        {
            /*File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");*/

            /*var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");*/


            //var linhas = File.ReadAllLines("contas.txt");
            //Console.WriteLine(linhas.Length);

            var linhas = File.ReadAllText("contas.txt");
            Console.WriteLine(linhas);


        }
    }


}
