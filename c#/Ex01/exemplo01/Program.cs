using System;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("olá pessoal!");
            Console.Write("\nolá \n Gilmar!");
            Console.ReadKey();

            int a = 20, c;
            string b = "10";
            c = a + Convert.ToInt32(b);
            Console.ForegroundColor = ConsoleColor.Blue ;
            Console.Write("a soma de {0} com {1} é {2}",a,b,c);
            Console.ReadKey();

            int j, l ;
            string k;
            Console.Write("\nDigite J:");
            
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite k:");
            k = Console.ReadLine();
            l = j + Convert.ToInt32(k);
            Console.WriteLine("a soma de {0} com {1} é {2}", j, k, l);
            Console.ReadKey();



        }
    }
}
