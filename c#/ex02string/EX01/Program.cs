using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
         
        {
            int num,num1,num2;
            //1. Leia um número e exiba o anterior e o próximo.

            Console.Write("Digite um  número\n");
            num = int.Parse(Console.ReadLine());
            num1 = num - 1;
            num2 = num + 1;
            Console.Write("\nO número anterior é {0}", num1);
            Console.Write("\nO número posterior é {0}", num2);
            Console.Write("\nO número anteriro é :{0} e o posterior é: {1}", num1,num2);
            Console.Write("\n-------------------------------------\n");

   
        }

    }
}
