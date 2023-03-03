using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorDigitadoPeloUsuario = 610;

            if (Fibonacci(valorDigitadoPeloUsuario))
                Console.WriteLine("O numero informado pertence a sequencia de Fibonacci.");
            else
                Console.WriteLine("O numero informado não pertence a sequencia de Fibonacci.");

            Console.ReadKey();
        }

        static bool Fibonacci(int valor)
        {
            if (valor == 0) 
                return true;

            int anterior = 0;
            int proximo = 1;

            while (proximo < valor)
            {
                int soma = anterior + proximo;
                anterior = proximo;
                proximo = soma;
            }

            return proximo == valor;
        }
    }
}
