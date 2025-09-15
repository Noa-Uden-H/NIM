using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void skiftspiller()
        {
            if (Globals.spiller = '1')
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
