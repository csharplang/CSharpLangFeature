using CSharpLangFeature.List._10ExtensionMethod;
using System;

namespace CSharpLangFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionMethodRun.Execute();
            //Serialization.DoSerialization();
            //Serialization.DoDeSerialization();

            //NonGeneric.HashSet();
            //Generic.CheckElementinLinkedList();

            //GenericDelegate _GenericDelegate = new GenericDelegate();
            //_GenericDelegate.Execute();
            //GenericMethod s = new GenericMethod();
            //s.GMethod<int>(101, 202);
            //DelegatesMain _DelegatesMain = new DelegatesMain();
            //_DelegatesMain.Execute();
            Console.ReadLine();
        }
    }
}
