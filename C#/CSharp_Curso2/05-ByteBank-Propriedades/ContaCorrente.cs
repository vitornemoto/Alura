using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBank_Propriedades
{
    public class ContaCorrente
    {
        /* private Cliente Titular
         {
             get
             {
                 return _titular;
             }
             set
             {
                 _titular = value;
             }
         }*/
        //private Cliente _titular;

        /*private int _agencia;
        private int _numero;
        private double _saldo = 100;*/

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        //propriedade statica (propriedade que pertence a classe e nao ao objeto)
        public static int TotalDeContasCriadas { get; private set; }

        //construtor
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }


        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}
