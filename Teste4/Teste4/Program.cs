using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste4
{
    public class Program
    {
        static void Main(string[] args)
        {
            float SP = 67836.43f;
            float RJ = 36678.66f;
            float MG = 29229.88f;
            float ES = 27165.48f;
            float Outros = 19849.53f;

            float total = SP + RJ + MG + ES + Outros;

            Console.WriteLine($"Percentual de representacao de SP: {(SP / total) * 100:f2}%");
            Console.WriteLine($"Percentual de representacao de RJ: {(RJ / total) * 100:f2}%");
            Console.WriteLine($"Percentual de representacao de MG: {(MG / total) * 100:f2}%");
            Console.WriteLine($"Percentual de representacao de ES: {(ES / total) * 100:f2}%");
            Console.WriteLine($"Percentual de representacao de Outros: {(Outros / total) * 100:f2}%");
            Console.ReadKey();


        }
    }
}
