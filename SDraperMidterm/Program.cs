using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDraperMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLength = 0;
            int secondLength = 0;
            int thirdLength = 0;
            bool goForward = true;
            bool loopForever = true; // I wasn't sure if I'd need to break out any other way


            do
            {
                Menu();
                string response = Console.ReadLine();
                if(int.TryParse(response, out int iResponse))
                {
                    if(iResponse == 1)
                    {
                        Console.WriteLine("Please enter the first length:");
                        string firstL = Console.ReadLine();
                        if(!int.TryParse(firstL, out firstLength))
                        {
                            Console.WriteLine("Please enter a valid integer for all sides.");
                            Console.WriteLine();
                            goForward = false;
                        }
                        else if(firstLength < 1)
                        {
                            Console.WriteLine("Please enter a positive value for all sides.");
                            Console.WriteLine();
                            goForward = false;
                        }
                        if(goForward)
                        {
                            Console.WriteLine("Please enter the second length:");
                            string secondL = Console.ReadLine();
                            if (!int.TryParse(secondL, out secondLength))
                            {
                                Console.WriteLine("Please enter a valid integer for all sides.");
                                Console.WriteLine();
                                goForward = false;
                            }
                            else if (secondLength < 1)
                            {
                                Console.WriteLine("Please enter a positive value for all sides.");
                                Console.WriteLine();
                                goForward = false;
                            }
                        }
                        if(goForward)
                        {
                            Console.WriteLine("Please enter the third length:");
                            string thirdL = Console.ReadLine();
                            if (!int.TryParse(thirdL, out thirdLength))
                            {
                                Console.WriteLine("Please enter a valid integer for all sides.");
                                Console.WriteLine();
                                goForward = false;
                            }
                            else if (thirdLength < 1)
                            {
                                Console.WriteLine("Please enter a positive value for all sides.");
                                Console.WriteLine();
                                goForward = false;
                            }
                        }

                        if(goForward)
                        {
                            string output = TriangleSolver.Analyze(firstLength, secondLength, thirdLength);
                            Console.WriteLine("The numbers you have entered form a "+ output + " triangle.");
                            Console.WriteLine();
                        }
                        
                    }
                    else if(iResponse == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there are only two options!");
                    }
                }   
                else
                {
                    Console.WriteLine("Sorry, you can only enter integers. (1-2)");
                }
                goForward = true;
            } while (loopForever);
            
        }

        static void Menu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
        }
    }
}
