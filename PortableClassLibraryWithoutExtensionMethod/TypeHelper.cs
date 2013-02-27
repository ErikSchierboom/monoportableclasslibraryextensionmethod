namespace PortableClassLibraryWithoutExtensionMethod
{
    using System;

    public static class TypeHelper
    {
        public static bool IsAssignableTo<T>(Type @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException("this");
            }

            return typeof(T).IsAssignableFrom(@this);
        }
    }
}