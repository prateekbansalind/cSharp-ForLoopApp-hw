using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a comma separated list of first names(no spaces).
           
            Console.Write("Write all the people first names separated by commas who are attending this party: ");
            string firstName = Console.ReadLine();

            //for example type  : prateek,john,harry

            //Split the string into a string array.Loop through the array and tell each person hello.

            string[] firstnames = firstName.Split(',');

            for (int i = 0; i < firstnames.Length; i++)
            {
                Console.WriteLine($"Hello, {firstnames[i]}"); 
            }




            Console.ReadLine();
        }
    }
}