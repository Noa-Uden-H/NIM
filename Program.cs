using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    internal class Program
    {
        public static class Globals
        {
            public static char spiller = 'N';
        }

        static void Main(string[] args)
        {
            int antalbrikker = 15; // Random antal?

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
                    Console.WriteLine($"{Globals.spiller} har tabt!");
                    break;
                }
            }
        }
        static void skiftspiller()
        {
            if (Globals.spiller == 'N')
            {
                Globals.spiller = 'R';
            }
            else
            {
                Globals.spiller = 'N';
            }
        }

        static int knapper()
        {
            Console.Write("tag 1 / 2 / 3 brikker: ");
            int remove = Convert.ToInt16(Console.ReadLine());

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
            Console.WriteLine($"spiller {Globals.spiller}");
        }
    }
}
