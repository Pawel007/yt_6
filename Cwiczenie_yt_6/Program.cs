using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_yt_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greeting();

                Age();

                Settings();
            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt= " + maxInt);
            Console.WriteLine("minInt= " + minInt);
            Console.WriteLine("maxLong= " + maxLong);
            Console.WriteLine("minLong= " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Komunikat zalezny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            // int age = int.Parse(Console.ReadLine());
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mozesz wypic piwo");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziles nie poprawny wiek");
            }
            else
            {
                Console.WriteLine("Dostaniesz mleko");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie uzytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje Imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
