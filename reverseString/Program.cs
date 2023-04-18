using System;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Amo minha família!";
            string fraseReversa = "";

            for(int i = frase.Length - 1; i >= 0; i--) 
            {
                fraseReversa += frase[i];
            }

            Console.WriteLine(fraseReversa);
        }
    }
}