using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Hex_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Decimal to Hex Converter!");
            Console.WriteLine("Enter a number to be converted.");
            Console.WriteLine("Use 'q' to exit the program.");
            
            beginConverting();


            void beginConverting()
            {
                string userInput;
                int userNum;
                /*
                do
                {
                    Console.Write("Number to convert: ");
                    userInput = Console.ReadLine();
                    if (userInput == "q")
                    {
                        Console.WriteLine("The user is quitting.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    else if (userInput != "q")
                    {
                        for (int i = 0; i < userInput.Length; i++)
                        {
                            //if (userInput[i] != )
                            {

                            }
                        }
                        
                        userNum = Convert.ToInt32(userInput);
                        //if (userInput )
                        Console.WriteLine("The user entered a number");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a numeric value, or 'q' to quit.");
                    }
                } //while (userInput == "q" || userNum >= 0 && userNum <= 1000000);

                do
                {
                    Console.Write("Number to convert: ");
                    userInput = Console.ReadLine();
                    //userNum = Convert.ToInt32(userInput);

                    if ()
                    {
                        Console.WriteLine("The user is quitting");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    else if (userInput != "q" || userInput != "Q" || userInput != "Quit" || userInput != "quit")
                    {
                        if (Convert.ToInt32(userInput) < 0 || Convert.ToInt32(userInput) > 1000000)
                        {
                            
                        }
                        
                    }
                    else
                    {
                        userNum = Convert.ToInt32(userInput);
                        //if (userNum >=
                    }
                } while (userInput != null);*/

                do
                {
                    //userInput = Console.ReadLine();
                    //userNum = Convert.ToInt32(userInput);

                    userNum = Convert.ToInt32(Console.ReadLine());
                    


                    if (userNum >= 0 && userNum <= 1000000)
                    {
                        Console.WriteLine("Getting a hex change");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        //hexChange();
                        beginConverting();
                    }

                    else
                    {
                        userInput = Convert.ToString(userNum);

                        if (userInput == "q" || userInput == "Q" || userInput == "Quit" || userInput == "quit")
                        {
                            Console.WriteLine("User is quitting");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                        }

                        else
                        {
                            System.Console.WriteLine("Please enter a valid number, or use 'q' to exit.");
                        }
                    }
                    /*
                    else if (userInput == "q" || userInput == "Q" || userInput == "Quit" || userInput == "quit")
                    {
                        Console.WriteLine("User is quitting");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    else
                    {
                        System.Console.WriteLine("Please enter a valid number, or use 'q' to exit.");
                    }*/

                } while (userNum != null);
            }

            void hexChange()
            {

            }
        }
    }
}
