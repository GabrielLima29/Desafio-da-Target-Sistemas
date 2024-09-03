using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os valores de faturamento diário separados por vírgula: ");
            string input = Console.ReadLine();
            decimal[] faturamento = input.Split(',').Select(decimal.Parse).ToArray();

            decimal[] faturamentoFiltrado = faturamento.Where(valor => valor > 0).ToArray();

            if (faturamentoFiltrado.Length == 0)
            {
                Console.WriteLine("Não há valores de faturamento para calcular.");
                return;
            }

            decimal menorValor = faturamentoFiltrado.Min();
            decimal maiorValor = faturamentoFiltrado.Max();
            decimal mediaMensal = faturamentoFiltrado.Average();
            int diasSuperioresAMedia = faturamentoFiltrado.Count(valor => valor > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: R$ {menorValor:F2}");
            Console.WriteLine($"Maior valor de faturamento: R$ {maiorValor:F2}");
            Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasSuperioresAMedia}");

        }
    }
}
