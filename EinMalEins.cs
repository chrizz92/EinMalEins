using System;

namespace EinMalEins.ConsoleApplication
{
    class EinMalEins
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 x 1 -Tabelle");

            for(int i = 1; i <=10;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,2} mal {1,2} ist {2,4}", j, i, i * j);
                }

                Console.WriteLine("\n\nBeliebige Taste drücken\n");
                Console.ReadKey();
            }
        }
    }
}
