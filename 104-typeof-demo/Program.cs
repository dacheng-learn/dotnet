using System;
using System.Net.Http;

namespace Typeof.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output our custom type, Program itself.
            Console.WriteLine(typeof(Program));
            
            // Output the sdk type.
            Console.WriteLine(typeof(Console));
            Console.WriteLine(typeof(HttpClient));
            
            // Output the actual type.
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(uint));
            Console.WriteLine(typeof(long));
            Console.WriteLine(typeof(ulong));
            Console.WriteLine(typeof(float));
            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(decimal));
            Console.WriteLine(typeof(string));
            
            // Output the same result.
            Console.WriteLine(typeof(bool));
            Console.WriteLine(typeof(Boolean));
        }
    }
}
