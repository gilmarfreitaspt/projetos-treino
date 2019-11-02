using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string c, c1, d, d1,maiu,minu,primai;
            Console.Write("\nDigite palavra 1:");
            c = Console.ReadLine();
            Console.Write("\nDigite palavra 2:");
            c1 = Console.ReadLine();
            Console.Write("\ntamanho da palavra 1:{0}",c.Length);
            Console.Write("\nconcatenado sem armazanar :{0}", c+c1);
            d = c;
            Console.Write("\no conteudo de  d: {0} ",d);
            d1 = c + c1;
            Console.Write("\n concatenação de d :{0}", d1);
            Console.Write("\nprimeiro caractere :{0}", c.Substring(0, 1));
            Console.Write("\núltimo caractere :{0}", c1.Substring(c1.Length -1, 1));
            Console.Write("\ntodos menos os primeiros :{0}", d1.Substring(2));
            Console.Write("\no Quarto elmento: {0}", c.Substring(3, 1));//indice 3
            Console.Write("\nos três primeiros elementos: {0}", c.Substring(0, 3));
            Console.Write("\nos três últimos  elmentos: {0}", c1.Substring(c1.Length -3, 3));
            Console.Write("\n-------------------------------------");

            maiu = d1.ToUpper();
            minu = d1.ToLower();
            primai = d1.Substring(0, 1).ToUpper() + d1.Substring(1).ToLower();
            Console.Write("\nO texto em caps: {0}\nO texto sem caps: {1}", maiu, minu);
            Console.Write("\nO texto com a 1º letra em caps: {0}",primai);
            Console.Write("\n-------------------------------------");

            string nome = " ISMAI ";
           
            Console.Write("\n--{0}--", nome.TrimEnd());
            Console.Write("\n--{0}--", nome.TrimStart());
            Console.Write("\n--{0}--", nome.Trim());

            Console.Write("\n-------------------------------------");
            string nome1 = "Gilmar";
            nome1 = nome1.PadRight(11, '*'); // "Rui*****"
            Console.Write("\n{0}", nome1);

            Console.Write("\n-------------------------------------");
            string codigo = "123";
            codigo = codigo.PadLeft(6, '0'); // "000123"
            Console.Write("\n{0}", codigo);

            Console.Write("\n-------------------------------------");
            string linha = "Teste, 10, 20, 10/06/2019";
            string[] campos = linha.Split(',');
            string linhaNova = String.Join(';', campos);
            Console.Write("\n{0}", linhaNova);
            Console.Write("\n{0}", campos[2]);

            Console.Write("\n-------------------------------------");


            double num = 0;
            Console.Write("Digite um  número");
            num = double.Parse(Console.ReadLine());
            /* a linha de  baixo faz exatamente que a linha de cima
             num = convert.ToDouble(Console.Readline());*/
             if (num%2==0)
                Console.Write("O número{0}é par", num);
             else
                Console.Write("O número{0}é impar", num);


        }
    }
}
