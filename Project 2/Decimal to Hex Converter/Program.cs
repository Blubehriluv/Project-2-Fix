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
            Console.WriteLine("Welcome to the Decimal to Hex Converter!");
            Console.WriteLine("Enter a number to be converted.");
            Console.WriteLine("Use the digits '000' to exit the program.");
            
            beginConverting();


            void beginConverting()
            {
                string userInput = Console.ReadLine();

                if (userInput == "q")
                {
                    Console.WriteLine("The user is quitting");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
                else if (userInput != "q")
                {
                    int userNum = Convert.ToInt32(userInput);
                    if (userNum > 0 && userNum < 1000000)
                    {
                        beginConverting();
                        hexChange();
                    }
                }
            }

            void hexChange()
            {

            }
        }
    }
}
