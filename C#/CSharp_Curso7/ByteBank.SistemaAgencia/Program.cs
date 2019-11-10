using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando da forma tradicional
            /*int[] idades = new int[6];


            idades[0] = 15;
            //idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 63;*/

            //criando array com o açucar sintatico
            /* int[] idades = new int[] { 15, 28, 35, 50, 28, 63 };

             int acumulador = 0;
             for (int indice = 0; indice < idades.Length; indice++)
             {
                 int idade = idades[indice];
                 Console.WriteLine($"Valor no indice {indice} : {idade}");
                 acumulador += idades[indice];
             }

             int media = acumulador / idades.Length;
             Console.WriteLine(media);*/


            //testando a classe ListaDeContaCorrente
            /*ListaDeContaCorrentes lista = new ListaDeContaCorrentes();
            ContaCorrente contaVitor = new ContaCorrente(145, 16555);
            ContaCorrente contaJulia = new ContaCorrente(147, 16555);
            lista.Adicionar(new ContaCorrente(345, 23456));
            lista.Adicionar(new ContaCorrente(363, 55666));
            lista.Adicionar(contaVitor);
            lista.Adicionar(new ContaCorrente(735, 77755));
            lista.Adicionar(new ContaCorrente(735, 77756));
            lista.Adicionar(new ContaCorrente(735, 77757));
            lista.Adicionar(new ContaCorrente(735, 77758));
            lista.Adicionar(new ContaCorrente(735, 77759));
            lista.Adicionar(new ContaCorrente(735, 77760));
            lista.Adicionar(new ContaCorrente(735, 77761));
            lista.Adicionar(new ContaCorrente(735, 77762));
            lista.Adicionar(new ContaCorrente(735, 77763));
            lista.Adicionar(new ContaCorrente(735, 77764));
            lista.Adicionar(new ContaCorrente(735, 77765));

            Console.WriteLine("testando classe escrever");
            Console.WriteLine("");
            lista.EscreverListaNaTela();

            lista.Remover(contaVitor);

            Console.WriteLine("testando classe escrever");
            Console.WriteLine("");
            lista.EscreverListaNaTela();*/


            // testando indexadores

            /* ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

             lista.Adicionar(new ContaCorrente(100, 40010));
             lista.Adicionar(new ContaCorrente(101, 40011));
             lista.Adicionar(new ContaCorrente(102, 40012));
             lista.Adicionar(new ContaCorrente(103, 40013));


             for (int i = 0; i < lista.Tamanho; i++)
             {
                 ContaCorrente conta = lista[i];
                 Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
             }*/


            //testando adicionar varios com foreach e paramns
            /*ListaDeContaCorrentes lista = new ListaDeContaCorrentes();
            lista.AdicionarVarios
            (
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            );*/



            // testando uma lista generica
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            idades.EscreverListaNaTela();

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");
            cursos.EscreverListaNaTela();

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
            contas.EscreverListaNaTela();



            Console.ReadLine();
        }
    }
}
