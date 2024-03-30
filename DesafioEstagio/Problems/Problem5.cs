using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstagio.Problems
{
    public class Problem5
    {
        public void Main()
        {
            Console.WriteLine("digite a palavra a ser invertida");
            string texto = Console.ReadLine();
            string invertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                invertido += texto[i];
            }

            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("Texto invertido: " + invertido);
        }
    }
}
