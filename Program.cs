using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzysteNieparzysteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, który informuje użytkownika o podanej liczbie, czy jest parzysta lub nieparzysta. \nPodaj liczbę: ");


            var userNumber = GetNumber();



            if (userNumber % 2 == 0)
            {
                Console.WriteLine("podana liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Podana liczba jest nieparzysta");
            }

            Console.ReadKey(true);
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("Podana warość nie jest liczbą całkowitą! \nSpróbuj ponownie:");
                    continue;
                }
                return number;
                
                
            }
        }
    }
}
