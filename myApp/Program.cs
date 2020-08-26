using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number here:");
            int user_input = Convert.ToInt32(Console.ReadLine());
            
            if (user_input % 2 == 0)

            {
                Console.WriteLine("Even Num...");
            } 
             else 
            {
                Console.WriteLine("Odd Num...");
       }
        }
    }
}
