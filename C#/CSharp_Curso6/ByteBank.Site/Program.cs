using System;
using System.Text.RegularExpressions;
using ByteBank.Modelos;

namespace ByteBank.Site
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste1
            /*string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');
            string argumentos = url.Substring(indiceInterrogacao+1);

            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(argumentos);*/

            //teste 2
            /*string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);

            int indiceValor = indice + nomeArgumento.Length;

            string valorArgumento = palavra.Substring(indiceValor+1);

            Console.WriteLine(valorArgumento);
            */

            //teste classe extrator argumentos
            /*string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(url);
            extrator.GetValor("moedaOrigem");// real
            extrator.GetValor("moedaDestino");//dolar
            extrator.GetValor("valor");

            Console.WriteLine(extrator.GetValor("moedaOrigem"));
            Console.WriteLine(extrator.GetValor("moedaDestino"));
            Console.WriteLine(extrator.GetValor("VALor"));*/

            // TESTE DE EXPRESSÓES REGULARES
            /*//string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}-[0-9]{4}";

            //string padrao = "[0-9]{4,5}-[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string texto = "Meu número é 2342-3453";

            Match match =  Regex.Match(texto,padrao);
            Console.WriteLine(match.Value);*/



            //Classe object (ToString) sobrescrevendo na classe conta corrente
            ContaCorrente conta = new ContaCorrente(342, 37652);
            Console.WriteLine(conta);

            //Classe object(Equals) sobrescrevendo na classe Cliente
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }





            Console.ReadLine();
        }
    }
}
