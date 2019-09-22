using System;

namespace CSharpLangFeature.BaseKeyword.Constructor
{
    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }
        public double GetNum() => num;
    }
}