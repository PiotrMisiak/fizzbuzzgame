using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {       
        static void Main(string[] args)
        {                      
            
            var fizzbuzz = new FizzBuzz();
            
            Console.WriteLine("Podaj liczbę i zagraj w grę FizzBuzz.");
            
            while (true)
            {               
                var number = GetNumber();
                Console.WriteLine(fizzbuzz.GameRules(number));
                Console.WriteLine("\nPodaj następną liczbę.\nJeżeli chcesz zakończyć grę wpisz: t");
            }
            
        }

        private static int GetNumber()
        {
            while (true)
            {
                var answer = Console.ReadLine();
                if (answer.ToUpper() == "T")
                    Environment.Exit(0);

                if (!int.TryParse(answer, out int number))
                {
                    Console.WriteLine("\nPodałeś nieprawidłowe dane, spróbuj jeszcze raz.");
                    continue;
                }
                return number;
            }
        }
    }

}
