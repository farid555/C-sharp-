﻿using System;

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
                Console.WriteLine("Even Number.");
            } 
             else 
            {
                Console.WriteLine("Odd Number.");
       }
        }
    }
}
