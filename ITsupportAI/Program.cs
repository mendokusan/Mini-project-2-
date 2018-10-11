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
            string name, ans, software;
            char help;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("What is your name? ");
            name = Convert.ToString(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Hello {0}, what kind of issues are you having: \nHardware(H) \nSoftware(S) \nPeripheral(P) \nInternet connection (I) \nNone(X)", name);
            help = Convert.ToChar(Console.ReadLine().ToUpper());
            Thread.Sleep(1000);
            Console.Clear();

            if (help == 'H')
            {
                Console.WriteLine("Hardware");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }


            if (help == 'S')
            {
                Console.WriteLine("Software");
                Console.WriteLine("Is the issue happening to all software? Y/N");

                ans = Convert.ToString(Console.ReadLine().ToUpper());
                if (ans == "Y")
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Have you tried updating the system software? Y/N");
                    ans = Convert.ToString(Console.ReadLine().ToUpper());

                    if (ans == "Y")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Try re-installing your Operating system and or software");
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Update the system software");
                    }
                }
                else if (ans == "N")
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("What software is it happening to? ");
                    software = Convert.ToString(Console.ReadLine());

                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Have you tried updating {0}? Y/N", software);
                    ans = Convert.ToString(Console.ReadLine().ToUpper());

                    if (ans == "Y")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Have you tried turning your computer off and on again? Y/N");
                        ans = Convert.ToString(Console.ReadLine().ToUpper());

                        if (ans == "Y")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Try re-installing {0}", software);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Turn your computer off and on again");
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Try to update {0} \nHas that fixed the issue? Y/N", software);
                        ans = Convert.ToString(Console.ReadLine().ToUpper());

                        if (ans == "Y")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Thanks for using our IT Support AI.\nGoodbye");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Try re-installing {0}", software);
                        }
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("That is not a valid input");
                    help = Convert.ToChar(Console.ReadLine().ToUpper());
                }

                Console.ReadLine();
            }


            if (help == 'P')
            {
                Console.WriteLine("Peripheral");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }


            if (help == 'I')
            {
                Console.WriteLine("Internet connection");
                Console.WriteLine("Is the issue, ");
                Console.ReadLine();
            }


            if (help == 'X')
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
