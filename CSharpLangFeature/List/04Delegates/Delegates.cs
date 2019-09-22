using System;

namespace CSharpLangFeature.List.Delegates
{
    public class Delegates
    {
        // Declaring the delegates 
        // Here return type and parameter type should  
        // be same as the return type and parameter type 
        // of the two methods 
        // "addnum" and "subnum" are two delegate names 
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        //public delegate float div(int a, int b);

        // method "sum" 
        public void Summation(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract" 
        public void Subtraction(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        public float Divition(float a, float b)
        {
            if (b > a) return b / a;
            return a / b;
        }
    }
}