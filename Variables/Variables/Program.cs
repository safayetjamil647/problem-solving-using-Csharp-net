using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;
            int sum;
            x = 6;
            y = 5;
            sum = x + y;

            Console.WriteLine(sum);
            */
            
            Console.WriteLine("Enter your first name");
           string myFirstname=Console.ReadLine();
           string myLastname = Console.ReadLine();
            Console.WriteLine("hello"+ myFirstname+" is "+myLastname);
        }
    }
}
