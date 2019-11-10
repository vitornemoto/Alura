using System;
using System.Collections.Generic;
using System.Text;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public int agencia;
        public int numero;
        public double saldo = 100;
        public Cliente titular;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}
