using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, 
            num2 = 1, 
            num3, 
            i, 
            numero;

            Console.Write("Digite um número: ");

            numero = int.Parse(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");
        
            for (i = 2; i < numero; ++i)
            {
                num3 = num1 + num2;

                Console.Write(num3 + " ");

                num1 = num2;
                num2 = num3;
            }
            if (numero == 0 || numero == 1)
            {
                Console.Write(numero);
            }
        }
    }
}