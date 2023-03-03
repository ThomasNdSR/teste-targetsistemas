using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String json = File.ReadAllText("dados.json");
            List<Faturamento> faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            float menorValor = faturamento.Select(i => i.valor).Min();
            float maiorValor = faturamento.Select(i => i.valor).Max();

            float media = 0, soma = 0;
            int contador = 0;

            for (int i = 0; i < faturamento.Count; i++)
            {
                if (faturamento[i].valor > 0)
                {
                    soma += faturamento[i].valor;
                    contador++;
                }

            }
            media = soma / contador;

            int diasAcimaDaMedia = 0;

            for (int i = 0; i < faturamento.Count; i++)
            {
                if (faturamento[i].valor > media)
                {
                    diasAcimaDaMedia++;
                    Console.WriteLine($"Dia {faturamento[i].dia}\n" +
                        $"Valor de faturamento: {faturamento[i].valor}\n");
                }
            }

            Console.WriteLine("Media = " + (soma / contador));
            Console.WriteLine("Quantidade de dias acima da media: " + diasAcimaDaMedia);
            Console.ReadKey();


        }
    }
}
