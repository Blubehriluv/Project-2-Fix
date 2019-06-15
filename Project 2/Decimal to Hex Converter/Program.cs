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

                try
                {
                    //userInput = Console.ReadLine();
                    //userNum = Convert.ToInt32(userInput);

                    userNum = Convert.ToInt32(Console.ReadLine());
                    userInput = Convert.ToString(userNum);


                    if (userNum >= 0 && userNum <= 1000000)
                    {
                        Console.WriteLine("Getting a hex change");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        //hexChange();
                        beginConverting();
                    }

                    else if (userInput == "q" || userInput == "Q" || userInput == "Quit" || userInput == "quit")
                    {
                        Console.WriteLine("User is quitting");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    else
                    {
                        System.Console.WriteLine("Please enter a valid number, or use 'q' to exit.");
                    }
                } // while (userNum != null);

                catch (System.FormatException e)
                {
                    userInput = Console.ReadLine();

                    if (userInput == "q" || userInput == "Q" || userInput == "Quit" || userInput == "quit")
                    {
                        Console.WriteLine("User is quitting");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    else
                    {
                        System.Console.WriteLine("Please enter a valid number, or use 'q' to exit.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }

                    throw;
                }
            }

            void hexChange()
            {

            }
        }
    }
}
