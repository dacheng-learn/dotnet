using System;

namespace DependencyInjection
{
    public class MyDependency: IMyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}