using System;
using System.IO;

namespace DirectoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "/tmp/gdc.dir";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            var gdcDir = Directory.CreateDirectory(path);
            gdcDir.CreateSubdirectory("sub");
            // Directory not empty
            // Directory.Delete(path);
            Directory.Delete(path, true);
            
            Console.WriteLine(Directory.GetCurrentDirectory());
            
            // permission problem
            // Directory.CreateDirectory("/gdc.no.permission");

            // empty path raise exception 
            // Directory.CreateDirectory("");
        }
    }
}