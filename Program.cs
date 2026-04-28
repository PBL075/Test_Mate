using System;

namespace TestLaMate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Cat va fi 1486-698 ?");
            int raspuns = Convert.ToInt32(Console.ReadLine());


            if (raspuns == 788)
            {
                Console.WriteLine("Raspunsul este corect!");
            }
            else
            {
                Console.WriteLine("Mai calculeaza");
                return;
            }
            Console.WriteLine("===================");
            Console.WriteLine("Mai departe , cat va fi 19406+16892");   
            int raspuns2 = Convert.ToInt32(Console.ReadLine());

            if (raspuns2 == 36298)
            {
                Console.WriteLine("Raspunsul este corect!");
            }
            else
            {
                Console.WriteLine("Nu este corect , mai calculeaza  ");
                return;
            }
            Console.WriteLine("===================");
            Console.WriteLine("Urmatoarea intrebare , cat va fi 275*34 ");
            int raspuns3 = Convert.ToInt32(Console.ReadLine());

            if (raspuns3 == 9350)
            {
                System.Console.WriteLine("Absolut corect!");
            }
            else
            {
                Console.WriteLine("Nu e corect , mai calculeaza");
                return;
            }
            Console.WriteLine("===================");
            Console.WriteLine("Ultima intrebare , cat va fi 1462/2");
            int raspuns4 = Convert.ToInt32(Console.ReadLine());

            if (raspuns4 == 731)
            {
                System.Console.WriteLine("Felicitari! Ai trecut testul ");
            }
            else
            {
                Console.WriteLine("Erai aproape sa treci testul");
                return;
            }
        }
    }
}