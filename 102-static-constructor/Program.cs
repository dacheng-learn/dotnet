using System;

namespace StaticConstructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1();
            Console.WriteLine("".PadLeft(30, '='));
            Test2();
            
            // Test2();
            // Console.WriteLine("".PadLeft(30, '='));
            // Test1();
        }

        private static void Test1()
        {
            App.Init();
            
            foreach (var model in App.Models)
            {
                Console.WriteLine(model.Name);
            }
        }

        private static void Test2()
        {
            App.Models.Add(new Model(){Name = "Hello World"});
            App.Models.Add(new Model("Success Go"));
            
            foreach (var model in App.Models)
            {
                Console.WriteLine($"model name is {model.Name}");
            }
        }
    }
}
