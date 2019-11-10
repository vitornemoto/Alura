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
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; set; }

        //propriedade statica (propriedade que pertence a classe e nao ao objeto)
        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        //construtor
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que zero.", nameof(agencia));
            }

            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que zero.", nameof(numero));
            }
            
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
            if (valor < 0)
            {
                throw new ArgumentException("Valor do saque não pode ser negativo.", nameof(valor));
            }
            if (this.Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this.Saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor da transferencia não pode ser negativo.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operacao não realizada.", ex);
            }


            contaDestino.Depositar(valor);
            return true;
        }
    }

}
