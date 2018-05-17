/*
 * Dette program demonstrerer øvelserne 5 - 11 fra https://www.introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382
 * Her antager jeg at alle øvelserne skrives i den samme klasse, her `HelloWorldPlus`, alle efter hinanden i `Main`.
 */

using System;

namespace HelloWorldPlus
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // øv 5
            Console.WriteLine("Hello World!");

            // øv 6
            Console.WriteLine("Søren Magnusson");

            // øv 6 version 2
            string fornavn = "Søren";
            string efternavn = "Magnusson";
            Console.WriteLine(fornavn + " " + efternavn);

            // øv 6 version 3
            Console.WriteLine("{0} {1}", fornavn, efternavn);

            // øv 7
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);

            // øv 8
            Console.WriteLine(DateTime.Now);
            
            // øv 9
            Console.WriteLine(Math.Sqrt(12345));

            // øv 10
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }

            // øv 11
            Console.Write("Skriv venligst din alder: ");
            double alder = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Om 10 år er du nok {0} år", alder + 10);
        }
    }
}
