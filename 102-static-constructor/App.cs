using System;

namespace StaticConstructor
{
    public class App
    {
        private static readonly App Instance;

        private readonly ModelList _models;

        public static ModelList Models => Instance._models;
        
        // static constructor will be called once
        static App()
        {
            Instance = new App();
            
            Console.WriteLine("static constructor called");
        }

        private App()
        {
            _models = new ModelList();
        }

        public static void Init()
        {
            Instance._models.Add(new Model());
        }
    }
}