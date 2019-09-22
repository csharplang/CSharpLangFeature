# C# | Generics – Introduction

* Generic is a class which allows the user to define classes and methods with the placeholder. Generics were added to version 2.0 of the C# language. 
* The basic idea behind using Generic is to allow type (Integer, String, … etc and user-defined types) to be a parameter to methods, classes, and interfaces. 

### Features of Generics. 
Generics is a technique that improves your programs in many ways such as:

1. It helps you in code reuse, performance and type safety.
1. You can create your own generic classes, methods, interfaces and delegates.
1. You can create generic collection classes. 1. The .NET framework class library contains many new generic collection classes in System.Collections.Generic namespace.
1. You can get information on the types used in generic data type at run-time.


#### Advantages of Generics

* Reusability: You can use a single generic type definition for multiple purposes in the same code without any alterations. For example, you can create a generic method to add two numbers. This method can be used to add two integers as well as two floats without any modification in the code.
* Type Safety: Generic data types provide better type safety, especially in the case of collections. When using generics you need to define the type of objects to be passed to a collection. This helps the compiler to ensure that only those object types that are defined in the definition can be passed to the collection.
* Performance: Generic types provide better performance as compared to normal system types because they reduce the need for boxing, unboxing, and typecasting of variables or objects.




#### Details: 
> https://www.geeksforgeeks.org/c-sharp-generics-introduction/
> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
