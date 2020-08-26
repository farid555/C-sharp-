using System;

namespace myApp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter the number:");
            int user_input = Convert.ToInt32(Console.ReadLine());

          
         for (int i = 1; i <= user_input; i++) 
         {
            if (user_input % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine("{0} is a Prime Number", user_input);
         } else {
            Console.WriteLine("Not a Prime Number");
         }
         //Console.ReadLine();
      }
   }
}