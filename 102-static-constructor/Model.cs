using System;

namespace StaticConstructor
{
    public class Model
    {
        public string Name { get; set; }

        public Model()
        {
            Name = "Default";
            
            Console.WriteLine("model() constructor called");
        }

        public Model(string name)
        {
            Name = name;
            
            Console.WriteLine("model(string) constructor called");
        }
    }
}