using System;

namespace basic_formatting
{
    /// <summary>
    /// learn path at microsoft docs
    /// <a href="https://docs.microsoft.com/en-us/learn/modules/csharp-basic-formatting/">basic string formatting</a>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Character Escape Sequences and Verbatim Strings ==");
            
            Console.WriteLine("-- simple escape characters --");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!");
            
            Console.WriteLine("-- verbatim with @ prefix --");
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tCompleted!");
            Console.WriteLine("Invoice: 1022\t\tCompleted!");
            Console.Write("\nOutput Directory: \t");
            Console.WriteLine(@"c:\invoices");
            
            Console.WriteLine("-- unicode --");
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            
            Console.WriteLine("-- escape, unicode and verbatim mix --");
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
            
            Console.WriteLine("== String Concatenation ==");

            Console.WriteLine("-- Concatenate multiple variables and literal strings. --");
            var firstName = "Success";
            var greeting = "Hello";
            var message = greeting + " " + firstName + "!";
            Console.WriteLine(message);
            Console.WriteLine(greeting + " " + firstName + "!");
            
            Console.WriteLine("== String Interpolation ==");
            
            Console.WriteLine("-- simple string interpolation --");
            Console.WriteLine($"{greeting} {firstName}!");

            Console.WriteLine("-- string interpolation and verbatim --");
            var projectName1 = "basic-formatting";
            Console.WriteLine($@"c:\output\{projectName1}");
            
            Console.WriteLine("== Challenge ==");
            
            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine("View English Output:");
            Console.Write("\t");
            Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
            Console.WriteLine($"{russianMessage}:");
            Console.WriteLine("\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");
        }
    }
}
