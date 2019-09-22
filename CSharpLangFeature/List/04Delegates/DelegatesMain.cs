using System;
using static CSharpLangFeature.List.Delegates.Delegates;

namespace CSharpLangFeature.List.Delegates
{

    public class DelegatesMain
    {
        public void Execute()
        {

            // creating object "obj" of class "Geeks" 
            Delegates _DelegatesTest = new Delegates();

            // creating object of delegate, name as "del_obj1"  
            // for method "sum" and "del_obj2" for method "subtract" & 
            // pass the parameter as the two methods by class object "obj" 
            // instantiating the delegates 
            addnum del_obj1 = new addnum(_DelegatesTest.Summation);
            subnum del_obj2 = new subnum(_DelegatesTest.Subtraction);
            //div del_obj3 = new div(_DelegatesTest.Subtraction);
            // pass the values to the methods by delegate object 
            del_obj1(100, 40);
            del_obj2(100, 60);
            //del_obj3(100, 50);

            //float abc = del_obj3(100, 50);

            // These can be written as using 
            // "Invoke" method 
            // del_obj1.Invoke(100, 40); 
            // del_obj2.Invoke(100, 60); 
        }
    }
}