using System;

namespace ConsoleAppFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.Version);
            Console.WriteLine(ClassLibraryStandard.Info.GetName());
            Console.WriteLine(ClassLibraryFramework.Info.GetName());
        }
    }
}
