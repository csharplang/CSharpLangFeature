# Extension Method in C#
* Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type. 
* In C#, the extension method concept allows you to add new methods in the existing class or in the structure without modifying the source code of the original type and you do not require any kind of special permission from the original type and there is no need to re-compile the original type. It is introduced in C# 3.0.

* Let us discuss this concept with the help of an example. Suppose you have a class or a structure which contains three methods and you want to add two new methods in this class or structure, you did not have the source code of the class/structure, or do not have permissions from the class/structure, or the class is a sealed class, but you still want to add new methods in it, then you can use the concept extension method to add the new method in the existing class/structure. Now you create a new class which is static and contain the two methods which you want to add in the existing class, now bind this class with the existing class. After binding you will see the existing class can access the two new added methods. As shown in the below program.


#### Points to Remember:
1. Extension methods are additional custom methods which were originally not included with the class.
1. Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
1. <b>The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.</b>
1. Extension methods can be used anywhere in the application by including the namespace of the extension method.



```csharp
class ExtensionMethods2    
{
    
    static void Main()
    {            
        int[] ints = { 10, 45, 15, 39, 21, 26 };
        var result = ints.OrderBy(g => g);
        foreach (var i in result)
        {
            System.Console.Write(i + " ");
        }           
    }        
}
//Output: 10 15 21 26 39 45
```


#### Details:
> https://www.geeksforgeeks.org/extension-method-in-c-sharp/
> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
> 










