using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    internal class Program
    {
        public static class Globals
        {
            public static string spiller1;
            public static string spiller2;
            public static string active;
        }

        static void Main(string[] args)
        {
            skriv_navne();
            int antalbrikker = antalbrikker_options();

            while (true)
            {
                vis_spiller();

                Random rnd = new Random();

                for (int i = 1; i <= antalbrikker; i++)
                {
                    int colornumber = rnd.Next(9, 13);
                    ConsoleColor color = (ConsoleColor)colornumber;
                    Console.ForegroundColor = color;

                    Console.Write("O");
                }
                Console.ResetColor();

                Console.Write($" ({antalbrikker})");
                Console.WriteLine(" ");

                int remove = knapper();
                antalbrikker -= remove;

                if (remove != 0)
                {
                    skiftspiller();
                }

                if (antalbrikker <= 0)
                {
                    skiftspiller();
                    Console.WriteLine($"{Globals.active} har tabt!");
                    break;
                }
            }
        }
        static void skiftspiller()
        {
            if (Globals.active == Globals.spiller1)
            {
                Globals.active = Globals.spiller2;
            }
            else
            {
                Globals.active = Globals.spiller1;
            }
        }

        static int knapper()
        {
            Console.Write("tag 1 / 2 / 3 brikker: ");
            int remove = 0;

            try
            {
                remove = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Det var ikke et tal!");
                return 0;
            }

            if (remove > 3)
            {
                Console.WriteLine("Forkert tal valgt");
                return 0;
            }
            if (remove < 1)
            {
                Console.WriteLine("Forkert tal valgt");
                return 0;
            }

            return remove;
        }

        static void vis_spiller()
        {
            Console.WriteLine($"{Globals.active}:");
        }

        static void skriv_navne()
        {
            Console.Write("Spiller 1: ");
            Globals.spiller1 = Convert.ToString(Console.ReadLine());
            Console.Write("Spiller 2: ");
            Globals.spiller2 = Convert.ToString(Console.ReadLine());
            Globals.active = Globals.spiller1;
        }
        static int antalbrikker_options()
        {
            Console.Write("Vil du vælge et antal? (y/n): ");
            char option = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if (option == 'Y')
            {
                Console.Write("Hvor mange brikker? ");
                int antal = Convert.ToInt16(Console.ReadLine());
                return antal;
            }
            else
            {
                Random rnd = new Random();
                return rnd.Next(10,99);
            }
        }
    }
}
