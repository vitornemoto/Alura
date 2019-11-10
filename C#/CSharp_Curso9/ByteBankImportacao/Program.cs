using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var arquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo)) // utilizar dessa forma é a mesma coisa que usar um using dentro do outro
            {

                /*var buffer = new byte[1024];
                var quantidadeDeBytesLidos = -1;
                while (quantidadeDeBytesLidos != 0)
                {
                    quantidadeDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, quantidadeDeBytesLidos);
                }*/

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStingParaContaCorrente(linha);
                    var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                }
            }
            Console.ReadLine();
        }

        static void EscreverBuffer(byte[]buffer, int bytesLidos)
        {
            var encoding = new UTF8Encoding();
            var texto = encoding.GetString(buffer,0,bytesLidos);

            Console.Write(texto);
        }

        static ContaCorrente ConverterStingParaContaCorrente(string linha)
        {
            // separa os valores através de um dígito separador
            string[] campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.',',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;

        }
    }
} 
 