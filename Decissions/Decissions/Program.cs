using System;

namespace Decissions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Big giveway!");
            Console.Write("Choose a door :1,2 or 3");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                string message = "You won a new car";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new plane";
                Console.WriteLine(message);
            }
            else
            {
                string message = "sorryyyy it s empty";
                Console.WriteLine(message);
            }
        }
    }
}
