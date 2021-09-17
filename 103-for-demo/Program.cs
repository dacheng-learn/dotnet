using System;

namespace For.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 循环打印10次 hello world
             */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World for i = {i+1}");
            }
        }
    }
}
