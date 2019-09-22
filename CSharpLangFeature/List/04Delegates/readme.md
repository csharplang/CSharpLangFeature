# C# | Delegates
* A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. Delegates in C# are similar to the function pointer in C/C++. It provides a way which tells which method is to be called when an event is triggered.
For example, if you click an Button on a form (Windows Form application), the program would call a specific method. In simple words, it is a type that represents references to methods with a particular parameter list and return type and then calls the method in a program for execution when it is needed.

#### Important Points About Delegates:

1. Provides a good way to encapsulate the methods.
1. Delegates are the library class in System namespace.
1. These are the type-safe pointer of any method.
1. Delegates are mainly used in implementing the call-back methods and events.
1. Delegates can be chained together as two or more methods can be called on a single event.
1. It doesn’t care about the class of the object that it references.
1. Delegates can also be used in “anonymous methods” invocation.
1. Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. Sometimes, these features together are known as anonymous functions.


