using System;

namespace Tema5Ex2
{
    // Ex.2 Scrieti un program care sa verifice daca un sir de caractere citit de la
    //      tastatura este sau nu palindrom.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti stringul!");
            string cuvant = Console.ReadLine();
            string invers = "" ;


            for (int i = cuvant.Length - 1; i >= 0; i--)
            {
                
                 invers += cuvant[i].ToString();
            }

            Console.WriteLine(invers);
        }
    }
}
