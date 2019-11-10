using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        // exemplo de chamada de lista extendida (para poder fazer a chamada desse metodo diretamente de um objeto List)
        /*public static void AdicionarVarios( this List<int> listaDeInteiros, params int[] itens)
        {
            foreach(int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }*/

        // exemplo de lista extendida generica (para qualquer tipo de lista), obs: a lista acima só aceitava número inteiro.
        public static void AdicionarVarios<T> (this List<T> listaDeInteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }

    }
}
