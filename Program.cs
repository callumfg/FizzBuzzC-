using System;
using System.Collections.Generic;
namespace FizzBuzzC_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string fizz;
            string fezz;
            string buzz;
            
            Console.WriteLine("Please give number you would like to count to");
            input = Console.ReadLine();
            Console.WriteLine("Would you like to implement the Fizz rule? y/n");
            fizz = Console.ReadLine();
            Console.WriteLine("Would you like to implement the Fezz rule? y/n");
            fezz = Console.ReadLine();
            Console.WriteLine("Would you like to implement the Buzz rule? y/n");
            buzz = Console.ReadLine();
           
            
            int inputNo = int.Parse(input);
            for (int i = 1; i <= inputNo; i++)
            {
                List<String> ans = new List<String>{};
                if (fizz == "y" && i % 3 == 0)
                {
                    ans.Add("Fizz");  
                }
                if (fezz == "y" && i % 13 == 0)
                {
                    ans.Add("Fezz");  
                }
                if (buzz == "y" && i % 5 == 0)
                {
                    ans.Add("Buzz");  
                }
                if (i % 7 == 0)
                {
                    ans.Add("Bang");  
                }
                if (i % 11 == 0)
                {
                    ans.RemoveAll(result => result != "Fezz");
                    ans.Add("Bong");
                }
                if (i % 17 == 0)
                {
                    ans.Reverse();  
                }

                if (ans.Count == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(string.Join("", ans));
                }
            }
        }
    }
}
