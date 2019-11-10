using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBank_Propriedades
{
    class SaldoInsuficienteException:Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this("Tentativa de saque de "+ valorSaque + " com saldo de "+ saldo) //chama a SaldoInsuficiente com o parâmetro de mensagem
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem)
            :base(mensagem)
        {

        }
    }
}
