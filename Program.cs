// Programmer: Wiley Hendry
// Tech Assignment 3
// ISM 4300
// 2/10/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input to determine increment n
            Console.Write("Please enter an increment value between 5 and 25: ");


            string cad = "";  
            try
            {
                // Variable will hold user input
                cad = Console.ReadLine();
                // Variable will be used in loops after turning the input into an int 
                int cad_value = int.Parse(cad);



                // Handling of invalid numeric inputs
                if ((cad_value < 5) || (cad_value > 25))
                {
                    Console.WriteLine("\nError: Please enter a value between 5 and 25");
                }
                // Handling correct value entries
                else if ((cad_value >= 5) && (cad_value <= 25))
                {
                    for (int i = 0; i <= 200; i = i + cad_value)
                    {

                        // USD Currency Conversion
                        decimal usd = (int)(i * 0.792367);
                        string mstring = usd.ToString("C");  

                        // 'Table' Creation
                        Console.WriteLine("CAD: {0}       USD: {1}", i, mstring);
                    }
                }
            }

            // If try block fails...
            catch
            {
                Console.WriteLine("\nPlease enter an integer value between 5 and 25 and try again.");
            }
        }
    }
}
