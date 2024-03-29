# base (C# Reference)

* The base keyword is used to access members of the base class from within a derived class:

* Call a method on the base class that has been overridden by another method.

* Specify which base-class constructor should be called when creating instances of the derived class.

* A base class access is permitted only in a constructor, an instance method, or an instance property accessor.

* It is an error to use the base keyword from within a static method.

* The base class that is accessed is the base class specified in the class declaration. For example, if you specify class ClassB : ClassA, the members of ClassA are accessed from ClassB, regardless of the base class of ClassA.






#### Details
> https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
