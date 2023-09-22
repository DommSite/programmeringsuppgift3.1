using System;
using System.Security.Cryptography;

namespace Uppgift_3.7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medlemsansökan till golfklubben");
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 50)
            {
                Console.WriteLine("Välkommen till golfklubben");
                    }
            else
            {
                Console.WriteLine("Tyvärr är du för ung för att gå med i golfklubben");
            }
        }
    }
}