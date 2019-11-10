using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBank_Propriedades
{
    class OperacaoFinanceiraException:Exception
    {
        public OperacaoFinanceiraException()
        {

        }
        public OperacaoFinanceiraException(string mensagem)
            :base(mensagem)
        {

        }
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {

        }
    }
}
