using System;

namespace CSharpLangFeature.List.Generics
{
    public class GenericClass<T>
    {
        public void genericMethod(T name, T location)
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);

        }
    }
}