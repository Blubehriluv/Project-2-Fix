using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Decimal_to_Hex_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introductions
            Console.WriteLine("Welcome to the Decimal to Hex Converter!");
            Console.WriteLine("Enter a number to be converted.");
            Console.WriteLine("Use 'q' to exit the program.");
            int userNum;

            beginConverting();

            //This begins the conversions
            void beginConverting()
            {
                //The user's input is stored to be checked as a string
                string userInput = Console.ReadLine();

                //If the user is quitting, the program will exit.
                if (userInput == "q")
                {
                    Console.WriteLine("The user is quitting");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
                //If the user isn't quitting and entering a number, the hexchange method will be called
                else if (userInput != "q")
                {
                    userNum = Convert.ToInt32(userInput);
                    //The number must be between 0 and 1000000
                    if (userNum > 0 && userNum < 1000000)
                    {
                        hexChange();
                    }
                }
            }

            void hexChange()
            {
                int placeHold = userNum;

                string hexStuff = placeHold.ToString("X");
                Console.WriteLine("You have converted {0} to {1}.", userNum, hexStuff);
                Console.WriteLine("Please enter another number.");
                beginConverting();
            }
        }
    }
}
