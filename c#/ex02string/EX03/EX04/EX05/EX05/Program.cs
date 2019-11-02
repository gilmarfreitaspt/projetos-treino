using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 5.Calcular a média final(teste 1 + teste 2 + teste 3 dividido por 3)dadas as notas
             dos 3 testes e produzir uma saída com a média e a situação do aluno de acordo
             com o seguinte critério: média >= 9.5, aprovado; média < 9.5, reprovado.*/


            Double mediaFinal, teste1, teste2,teste3;

             Console.Write("Qual a primeira nota\n");
            teste1 = double.Parse(Console.ReadLine());
            Console.Write(" Qual a segunda nota\n");
            teste2 = double.Parse(Console.ReadLine());
            Console.Write(" Qual a terceira nota\n");
            teste3 = double.Parse(Console.ReadLine());

            mediaFinal = (teste1 + teste2 + teste3) / 3;
            if (mediaFinal >= 9.5)
                Console.Write("\nParabéns está Aprovado e sua média é {0}",mediaFinal);
            else
                Console.Write("\nEstás Reprovado e sua média é {0}",mediaFinal);



        }
    }
}
