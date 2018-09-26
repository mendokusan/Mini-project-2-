using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITsupportAI
{
    class Program
    {
        static void Main()
        {
            //intro
            string name;
            Char help;

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("What is your name? ");
            name = Convert.ToString(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Hello {0}, what issue are you having: Hardware(H) Software(S) Peripheral(P) Internet connection (I) None(X)?", name);
            help = Convert.ToChar(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            if ((help == 'H') || (help == 'h'))
            {
                Console.WriteLine("Hardware");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }

            if ((help == 'S') || (help == 's'))
            {
                Console.WriteLine("Software");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }

            if ((help == 'P') || (help == 'p'))
            {
                Console.WriteLine("Peripheral");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }

            if ((help == 'I') || (help == 'i'))
            {
                Console.WriteLine("Internet connection");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }

            if ((help == 'X') || (help == 'x'))
            {
                Console.WriteLine("No issues today?");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(". . . . . ");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(" Goodbye ");
                Thread.Sleep(1000);
                Console.Clear();
            }


        }
    }
}
