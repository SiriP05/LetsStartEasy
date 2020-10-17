/* Prints "Fizz" if number is divisible by 3 and 
  Prints "Buzzzz" if number is divisible by %
  if divisible by both 3 & 5 then prints "mango"*/
  

using System;
namespace FizzBuzz
{
    class Program
    {
       
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i%3==0)
                {
                    Console.Write("\tMango");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("\tBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("\tFizz");
                }
                else
                    Console.Write("\t" + i);
            }
        }
    }
   
}
