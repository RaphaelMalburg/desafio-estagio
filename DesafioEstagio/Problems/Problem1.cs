using System;

namespace DesafioEstagio.Problems
{
    class Problem1
    {
        public void Main()
        {
            int soma = 0;
            int k = 0;
            Console.WriteLine("Digite o valor do índice:");
            int indice = int.Parse(Console.ReadLine());

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine(soma);
        }
    }
}
