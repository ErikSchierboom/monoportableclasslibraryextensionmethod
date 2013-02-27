namespace PortableClassLibraryWithExtensionMethod
{
    using System;

    public static class TypeExtensions
    {
        public static bool IsAssignableTo<T>(this Type @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException("this");
            }

            return typeof(T).IsAssignableFrom(@this);
        }
    }
}