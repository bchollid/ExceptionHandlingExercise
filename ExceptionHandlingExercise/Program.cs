using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[] {'1', '2', '3', '4', '5', '6', 'a', 'b', 'c'};

            List<int> numbers = new List<int>();

            string str = "";

            foreach(char character in arr)
            {
                try
                {
                    str = character.ToString();
                    int charAsInt = Int32.Parse(str);
                    numbers.Add(charAsInt);
                }
                catch
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
