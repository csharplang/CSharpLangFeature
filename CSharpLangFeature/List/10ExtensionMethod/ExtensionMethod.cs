using System;

namespace CSharpLangFeature.List._10ExtensionMethod
{

    public static class ExtensionMethodRun
    {
        public static void Execute()
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);

            int number = 100;
            bool result2 = number.IsGreaterThan(20);
            Console.WriteLine(result2);

            //Ex02
            MethodList g = new MethodList();
            g.M1();
            g.M2();
            g.M3();
            g.M4();
            g.M5("Method Name: M5");
        }
    }


    public static class ExtensionMethod
    {
        public static void M4(this MethodList g)
        {
            Console.WriteLine("Method Name: M4");
        }

        public static void M5(this MethodList g, string str)
        {
            Console.WriteLine(str);
        }

        public static bool IsGreaterThan(this int number, int value)
        {
            return number > value;
        }
    }
}
