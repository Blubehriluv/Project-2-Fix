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
                        userNum = Convert.ToInt32(userInput);
                        Console.WriteLine("The user entered a number");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a numeric value, or 'q' to quit.");
                    }
                } while (userInput != null);
                
                
                

            }
        }
    }
}
