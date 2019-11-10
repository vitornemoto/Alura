using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //ContaCorrente conta = new ContaCorrente(234, 34234);
            //var conta = new ContaCorrente(234, 34234); // o compilador transforma em "ContaCorrente conta"
            var idades = new List<int>();
            idades.AdicionarVarios(1, 5, 25, 38, 61, 14);
            idades.Sort(); // ordena a lista

            foreach (var idade in idades)
            {
                Console.WriteLine(idade);
            }


            var nomes = new List<string>()
            {
                "Vinicius",
                "Gisele",
                "Mayra",
                "Vasco"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            // testando tipo conta corrente
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                null,
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 48950),
                null,
                new ContaCorrente(290, 18950)
            };

            //contas.Sort(); --> chama a implementação dada em IComparable
            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            /*foreach (var conta in contas) // utilizando o Sort
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }*/

            //var contasOrdenadas = contas.OrderBy(conta => conta.Numero);
            //expandindo a expressão lambda
            /*var contasOrdenadas = 
                    contas.OrderBy(a =>
                    {
                        if (a == null)
                        {
                            return int.MaxValue;
                        }
                        return a.Numero;
                    });*/

            // outra forma de filtrar o nulo com o lamda
            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);
            foreach (var conta in contasOrdenadas) // utilizando o orderby
            {
                if (conta != null)
                { 
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }

            Console.ReadLine();
        }


        public static void TestarLista()
        {
            // Lista do .net
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);
            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);

            }
        }

        public static void TestarListaGenerica()
        {
            List<int> idades = new List<int>();

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);

            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);

            }

            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Vitor", "Julia", "Tusa");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);

            }



            Console.ReadLine();
        }
    }


}
