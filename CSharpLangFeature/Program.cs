using System;
using CSharpLangFeature.List.Delegates;
using CSharpLangFeature.List.Generics;
using CSharpLangFeature.List.Serialization;
using CSharpLangFeature.ListCollection;

namespace CSharpLangFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialization.DoSerialization();
            Serialization.DoDeSerialization();

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
