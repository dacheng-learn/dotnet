using System;

namespace IntExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 28;
            Console.WriteLine($"My age is {age} years old.");

            int temp;
            bool parseOk = int.TryParse("-13", out temp);
            Console.WriteLine($"Parse int status: {parseOk}.");
            Console.WriteLine($"Today's temp is {temp}.");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"max int is: {max}");
            Console.WriteLine($"min int is: {min}");
        }
    }
}
