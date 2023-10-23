using System;

namespace Uppgift4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int storstaTal = 0;

            Console.WriteLine("Skriv in ett heltal: ");
            int tal1 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Skriv ett till heltal, eller avsluta med 0");
                int tal2 = int.Parse(Console.ReadLine());

                if (tal1 > storstaTal)
                {
                    storstaTal = tal1;
                }

                else if (tal2 > storstaTal)
                {
                    storstaTal = tal2;
                }
                
                else if (tal2 == 0)
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Programmet har avslutats. Det största talet du skrev in är: " + storstaTal);
        }
    }
}
