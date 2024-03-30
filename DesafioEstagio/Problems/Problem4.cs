using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstagio.Problems
{
    public class Problem4
    {
        public void Main()
        {
            Console.WriteLine("Digite o numero que deseja conferir se pertence a sequencia de fibonacci");
            int numero = int.Parse(Console.ReadLine());
            bool ehFibo = false;
            int anterior = 0;
            int atual = 1;
            int proximo;

            while (atual <= numero)
            {
                proximo = anterior + atual;
                if (proximo == numero)
                {
                    ehFibo = true;
                }
                anterior = atual;
                atual = proximo;
            }
            if (ehFibo)
            {
                Console.WriteLine($"O numero {numero} é fibonacci");
            }
            else
            {
                Console.WriteLine($"O numero {numero} nao é fibonacci");
            }

        }
    }
}
