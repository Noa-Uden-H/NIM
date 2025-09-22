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
            public static char spiller = '1';
        }

        static void Main(string[] args)
        {
            int antalbrikker = 15; // Random antal?

            while (true)
            {
                Random rnd = new Random();

                for (int i = 1; i != antalbrikker; i++)
                {
                    int colornumber = rnd.Next(9, 13);
                    ConsoleColor color = (ConsoleColor)colornumber;
                    Console.ForegroundColor = color;

                    Console.Write("O");
                }
                Console.ResetColor();

                break;
            }
        }
        static void skiftspiller()
        {
            if (Globals.spiller == '1')
            {
                Globals.spiller = '2';
            }
            else
            {
                Globals.spiller = '1';
            }
        }

        static int knapper()
        { 
            Console.Write($"spiller {Globals.spiller} - tag 1/2/3 brikker");
            int remove = Convert.ToInt16(Console.ReadLine());

            return remove;
        }
    }
}
