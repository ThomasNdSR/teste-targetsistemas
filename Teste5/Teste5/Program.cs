using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String texto = "String a ser invertida";
            String textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }
            Console.WriteLine($"String invertida: {textoInvertido}");
            Console.ReadKey();
        }
    }
}
