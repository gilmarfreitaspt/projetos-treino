using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Calcular a quantidade de dinheiro gasta por um fumador até ao momento atual
   Dados: o nº de anos que fuma, o nº de cigarros por dia e o preço de um maço.*/
            double anosFuma, cigarroDia, precomaco, totalGasto;

            Console.Write("há Quantos anos fumas\n");
            anosFuma = double.Parse(Console.ReadLine());
            Console.Write(" Quantos cigarros fumas por dia\n");
            cigarroDia = double.Parse(Console.ReadLine());
            Console.Write(" Qual o preço do março de cigarros\n");
            precomaco = double.Parse(Console.ReadLine());
            totalGasto = (cigarroDia * 365 * anosFuma) / 20 * precomaco;
            Console.Write("\nO total gasto: {0} Euros", totalGasto);
            Console.Write("\nFumas há {0} anos um total de {1} cigarros por dia \ne já gastou até agora {2} Euros", anosFuma, cigarroDia, totalGasto);

            Console.Write("\n-------------------------------------\n");






        }
    }
}
