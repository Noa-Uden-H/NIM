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
    }
}
