using System;
namespace inllämningsupgift
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            Console.WriteLine(" ");
            string a = Console.ReadLine();
            double b =double.Parse(a);
            Console.WriteLine("vilken potens vill du se talet i?");
            Console.WriteLine(" ");

            string c =Console.ReadLine();
            double d =double.Parse(c);
            Console.WriteLine("potensen av " + a + " i " + c + " blir " + Potensberäkning(b, d));
        }
        static double Potensberäkning(double tal1, double tal2)
        {
            
            {
                double tal3;
                for (double i =0; tal2 < i; i++)
                {
                    tal3= tal1 * tal1 ;
                }
                return tal3;
            }
        }
    }
}