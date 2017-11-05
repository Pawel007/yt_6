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
            Console.Write("Wpisz swoje Imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);

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

            Console.ReadKey();
        }
    }
}
