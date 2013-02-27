namespace ConsoleApplicationWithoutExtensionMethod
{
    using System;
    using System.Linq;
    using System.Reflection;

    using PortableClassLibraryWithoutExtensionMethod;

    internal class Program
    {
        private static void Main()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(TypeHelper.IsAssignableTo<string>);

            Console.WriteLine("Number of string types found: {0}", types.Count());
        }
    }
}