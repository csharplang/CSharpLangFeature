using System;

namespace CSharpLangFeature.List.Generics
{
    public class GenericMethod
    {
        public void GMethod<T>(T a, T b)
        {
            Console.WriteLine("Param1: {0}", a);
            Console.WriteLine("Param2: {0}", b);

        }
        public bool Compare<T>(T x, T y)
        {
            if (x.Equals(y)) return true;
            else return false;
        }
    }
}