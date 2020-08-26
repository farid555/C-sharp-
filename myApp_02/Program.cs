using System;

namespace myApp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Input the Number");
            int user_input = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= user_input; i++)
            {
                if (user_input % i == 0)
                {
                  count++;
                  
                }
                if (count == 2)
                {
                    Console.WriteLine("This is a prime number");
                }
                else
                {
                    Console.WriteLine("This is not");
                }
                
            }
        }
    }
}
