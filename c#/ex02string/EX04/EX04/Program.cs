using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na   tela:
         
             a) A soma b) A diferença c)O produto d) O quociente    */

            int n1, n2, soma, diferenca, produto, divisao;
            Console.Write("Digite o primeiro número \n");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um  número para divisor \n");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            diferenca = n1 - n2;
            produto = n1 * n2;
            divisao = n1 / n2;
            Console.Write("\nA soma é  {0}, A diferença é  {1},O produto é {2}, A divisão é {3}", soma, diferenca, produto, divisao);
            Console.Write("\n-------------------------------------\n");


            
        }
    }
}
