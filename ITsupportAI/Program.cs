using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITsupportAI
{
    class Program
    {
        static void Main()
        {
            string name;
            Char help;

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Hello what is your name? ");
            name = Convert.ToString(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Hello {0}, what issue are you having: Hardware(H) Software(S) Peripheral(P)?", name);
            help = Convert.ToChar(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            if ((help == 'H') || (help == 'h'))
            {
                Console.WriteLine("Hardware");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();



            }

        }
    }
}
