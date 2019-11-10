using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    class ComparadorContaCorrentePorAgencia : Comparer<ContaCorrente>
    {
        public override int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            if (x.Agencia < y.Agencia)
            {
                return -1; // X fica na frente de Y
            }
            if (x.Agencia == y.Agencia)
            {
                return 0; // são iguais
            }
            return 1;


            //  podemos subtituir a logica acima por uma vez que o tipo int implementa a interface IComparer!
            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
