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
            string name, ans, software, answer, power_on, bios, led, answerinternet;
            char help, Popt, perans;

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

                Console.WriteLine("Does the Computer start? Y/N: ");
                power_on = Convert.ToString(Console.ReadLine().ToUpper());

                if (power_on == "Y")
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Does your computer boot into the Bios? Y/N: ");
                    bios = Convert.ToString(Console.ReadLine().ToUpper());

                    if (bios == "Y")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Try updating your hardware drivers");
                    }

                    else
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Try look up the beep code for your motherboard");
                    }

                }

                else
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Does the motherboard have a led on it? Y/N");
                    led = Convert.ToString(Console.ReadLine().ToUpper());

                    if (led == "Y")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Check to see if you have plugged everything in propperly. you can research the motherboard model and find everything you need to know");
                    }

                    else
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("You may have busted your motherboard or just need to make sure it is plugged in and switeched on");
                    }

                }

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
                Console.WriteLine("Is the issue involving: Mouse(m), Keyboard(k) or Screen(s).");
                Popt = Convert.ToChar(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Clear();

                if (Popt == 'm')
                {
                    Console.WriteLine("Mouse");
                    Console.WriteLine("Is your mouse plugged in (y) oy (n)");
                    perans = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    if (perans == 'y')
                    {
                        Console.WriteLine("There is likely a hardware issue with your mouse and will need to seek proffesional help");
                        Thread.Sleep(4000);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Plug in your mouse, if this dosent fix the issue there is likely a hardware issue with your mouse and will need to seek proffesional help");
                        Thread.Sleep(4000);
                        Console.Clear();
                    }

                }

                if (Popt == 'k')
                {
                    Console.WriteLine("Keyboard");
                    Console.WriteLine("Is your Keyboard plugged in (y) oy (n)");
                    perans = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    if (perans == 'y')
                    {
                        Console.WriteLine("There is likely a hardware issue with your Keyboard and will need to seek proffesional help");
                        Thread.Sleep(4000);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Plug in your mouse, if this dosent fix the issue there is likely a hardware issue with your Keyboard and will need to seek proffesional help");
                        Thread.Sleep(4000);
                        Console.Clear();
                    }

                }

                if (Popt == 's')
                {
                    Console.WriteLine("Screen");
                    Console.WriteLine("Is the power plugged in and or switched on (y) oy (n)");
                    perans = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    if (perans == 'y')
                    {
                        Console.WriteLine("Are you able to get any visual display on screen (y) or (n)");
                        perans = Convert.ToChar(Console.ReadLine());
                        Console.Clear();

                        if (perans == 'y')
                        {
                            Console.WriteLine("Try turning brightness settings up on side of monitor, if unable to do so you will likely need proffessional help.");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        if (perans == 'n')
                        {
                            Console.WriteLine("You likely have a hardware fault and will have to get professional help.");
                            Console.ReadLine();
                            Console.Clear();
                        }

                    }

                    if (perans == 'n')
                    {
                        Console.WriteLine("Plug power in or switch on, if unable to do so you will likely need proffessional help.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

            }


            if (help == 'I')
            {
                Console.WriteLine("Internet connection");
                Console.WriteLine("Have you tried resetting your router?");
                answerinternet = Convert.ToString(Console.ReadLine().ToUpper());
                if (answerinternet == "Y")
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Have you tried disconnecting the wifi from your device and then reconnect?Y/N:");
                    answerinternet = Convert.ToString(Console.ReadLine().ToUpper());
                    if (answerinternet == "Y")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Have you tried checking for spyware, viruses, and malware?Y/N:");
                        answerinternet = Convert.ToString(Console.ReadLine().ToUpper());
                        if (answerinternet == "Y")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Have you tried moving your router for a better connection?Y/N");
                            answerinternet = Convert.ToString(Console.ReadLine().ToUpper());

                            if (answerinternet == "Y")
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine(@"I suggest you to contact your internet provider. 
Have a nice day.");

                            }
                            else
                            {
                                Console.WriteLine(@"Please move you router to another location.
Did that solve the issue?");
                                answerinternet = Convert.ToString(Console.ReadLine().ToUpper());
                                if (answerinternet == "Y")
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.WriteLine(@"Thank you using out AI service." +
                                        "Goodbye!");
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.WriteLine(@"I suggest you to contact your internet provider.
Have a great day!");
                                }
                            }
                        }
                    }
                }


                else
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine(@"Please try resetting your router.
Did that fix the issue?");
                    answerinternet = Convert.ToString(Console.ReadLine().ToUpper());
                    if (answerinternet == "Y")
                    {
                        Console.WriteLine(@"Thank you for using our IT support.
Have a great day.");
                    }
                    else
                    {
                        Console.WriteLine(@"I suggest you to contact your internet provider. +
Have a great day!");
                    }
                }
                    }



                    Console.ReadLine();
                    



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
        
    



