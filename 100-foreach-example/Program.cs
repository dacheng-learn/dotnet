using System;
using System.Collections.Generic;

namespace ForeachExample
{
    class Program
    {
        static void Main()
        {
            var apples = new List<int> { 1, 2, 3, 9, 22, 500 };
            foreach (var apple in apples)
            {
                Console.WriteLine(apple);
            }
        }
    }
}
