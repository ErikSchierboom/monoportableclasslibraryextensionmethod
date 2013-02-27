namespace ConsoleApplicationWithExtensionMethod
{
    using System;
    using System.Linq;
    using System.Reflection;

    using PortableClassLibraryWithExtensionMethod;

    internal class Program
    {
        private static void Main()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsAssignableTo<string>());

            Console.WriteLine("Number of string types found: {0}", types.Count());
        }
    }
}