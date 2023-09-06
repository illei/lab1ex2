using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nr1;
            double nr3;
            double nr2;
            double medAr;
            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura
            */
            Console.WriteLine("Introduceti primul numar:");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            nr2 = int.Parse(Console.ReadLine());
            medAr = (nr1 + nr2 + nr3)/3;


            Console.WriteLine("media Aritmetica :" + medAr);
        }
    }
}
