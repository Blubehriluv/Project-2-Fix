using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Hex_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Welcome to the Decimal to Hex Converter!");
            Console.WriteLine("Enter a number to be converted.");
            Console.WriteLine("Use 'q' to exit the program.");
            
            beginConverting();


            void beginConverting()
            {
                foreach (var value in values)
                {
                    int number;

                    bool success = Int32.TryParse(value, out number);
                    if (success)
                    {
                        Console.WriteLine("Converted '{0}' to {1}.", value, number);
                    }
                    else
                    {
                        Console.WriteLine("Attempted conversion of '{0}' failed.",
                            value ?? "<null>");
                    }
                }
            }
        }
    }
}
