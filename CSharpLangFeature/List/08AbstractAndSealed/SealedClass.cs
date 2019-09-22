using System;

namespace CSharpLangFeature.List.AbstractAndSealed
{
    public class IMP
    {
        public void Execute()
        {
            SealedClass slc = new SealedClass();

            // Performing Addition operation 
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
        }
    }

    sealed public class SealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    // Inheriting the Sealed Class: Error: cannot derive from sealed type
    //class Example1 : SealedClass
    //{
    //}

    // Inheriting the Non Sealed Class 
    class Example2 : IMP
    {
    }
}