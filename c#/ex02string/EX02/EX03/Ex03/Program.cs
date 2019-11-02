using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*3. Ler dois números inteiros, A e B, e imprimir o quociente e o resto da divisão
             inteira entre eles.*/
            int divisor, dividendo, quociente, resto;
            Console.Write("Digite um  número para divisor\n");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Digite um  número para divisor \n");
            divisor = int.Parse(Console.ReadLine());

            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            Console.Write("\no quociente é  {0} e o resto é {1} ", quociente, resto);
            Console.Write("\n-------------------------------------\n");

           
        }
    }
}
