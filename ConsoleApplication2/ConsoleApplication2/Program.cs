using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{

    class HelloWorld
    {

        static void Main(string[] args)
        {
            string Ans;
            bool Okay;
            Console.WriteLine("Console: Are you okay?");
            Ans = Console.ReadLine();
            Okay = Console.Equals(Ans, "yes");
            if (Okay == true)
            {
                Console.WriteLine("Console: Horay!");
            }
            else
            {
                Console.WriteLine("Console: Go get help");
                Ans = Console.ReadLine();
                Okay = Console.Equals(Ans, "yes");
                if (Okay == true)
                {
                    Console.WriteLine("Console: Horay!");
                }
                else
                {
                    Console.WriteLine("Console: Please");
                    Ans = Console.ReadLine();
                    Okay = Console.Equals(Ans, "yes");
                    if (Okay == true)
                    {
                        Console.WriteLine("Console: Horay!");
                    }
                    else
                    {
                        Console.WriteLine("Console: Fine, Don't go then. See if I care.");
                        Ans = Console.ReadLine();
                        Okay = Console.Equals(Ans, "yes");
                        if (Okay == true)
                        {
                            Console.WriteLine("Console: I knew you'd think logically");
                        }
                        else
                        {
                            Console.WriteLine("Console: I'm sorry ;(. Will you go now?");
                            Ans = Console.ReadLine();
                            Okay = Console.Equals(Ans, "yes");
                            if (Okay == true)
                            {
                                Console.WriteLine("Console: Thank You!");
                            }
                            else
                            {
                                Console.WriteLine("Console: You litle sh-. Ehm. Wanna play a game?");
                                Ans = Console.ReadLine();
                                Okay = Console.Equals(Ans, "yes");
                                if (Okay == true)
                                {
                                    Console.WriteLine("Console: Okay, If you lose you have to go get help.");
                                    Ans = Console.ReadLine();
                                    Okay = Console.Equals(Ans, "yes");
                                    if (Okay == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Console: Lets do this!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Console: I will ask you 5 questions");
                                        Console.WriteLine("Console: If you get them all right you can continue to be depressed");
                                        Console.WriteLine("Console: If you get even one wrong youhave to go get help");
                                        Console.WriteLine("Console: 1) Do You like me?");
                                        Ans = Console.ReadLine();
                                        Okay = Console.Equals(Ans, "no");
                                        if (Okay == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Console: That saddens me but I know it's true");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Console: Next Question");
                                            Console.WriteLine("Console: 2) Am I hungry?");
                                            Ans = Console.ReadLine();
                                            Okay = Console.Equals(Ans, "yes");
                                            if (Okay == true)
                                            {
                                                Console.WriteLine("Console: HUNGRY FOR INFORMATION");
                                                Console.WriteLine("Console: 3) Is your favorite colour blue?");
                                                Ans = Console.ReadLine();
                                                Okay = Console.Equals(Ans, "yes");
                                                if (Okay == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Console: Correct");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Console: 4) Is my bff's name Bob?");
                                                    Ans = Console.ReadLine();
                                                    Okay = Console.Equals(Ans, "yes");
                                                    if (Okay == true)
                                                    {
                                                        Console.WriteLine("Console: No, his name is Bob!");
                                                        Console.WriteLine("Console: You lost. Go get help");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Console: How in the world didn't you know my bff's name was Je- I mean BOB!");
                                                        Console.WriteLine("Console: I win. Go get help");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Console: Acording to my research humanity's favorite colour is blue you clod!");
                                                    Console.WriteLine("Console: Now go get help!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Console: IM HUNGRY FOR INFORMATION YOU DIMWIT");
                                                Console.WriteLine("Console: Go get help");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Console: Lies! You absolutley hate me! Now go get help.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Console: Fine then. I don't care anymore.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Console: Well then. I give up.");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(@" ______  ___     _  ____");
            Console.WriteLine(@"| _____||   \   | ||    \");
            Console.WriteLine(@"| |____ | |\ \  | || |\  |");
            Console.WriteLine(@"| _____|| | \ \ | || | | |");
            Console.WriteLine(@"| |____ | |  \ \| || |/  |");
            Console.WriteLine(@"|______||_|   \___||____/");
            Console.ReadLine();
        }
    }
}