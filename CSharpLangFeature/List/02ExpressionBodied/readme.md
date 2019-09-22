# Expression-bodied members

### What is Expression Bodied Members?
* Expression Bodied member was introduced in C#6.0 and enhanced in C#7.0.
Expression Bodied is a new technique or implementation to make code concise and readable.
Expression Bodied makes the type member(Constructor, Destructor, Methods, Property, Indexer) defined in a single expression.
Expression Bodied members can only be applied to the below list of type members:
Constructor introduced in C#7.0
Destructor introduced in C#7.0
Property get accessor introduced in C#6.0
Property set accfessor introduced in C#7.0
Methods introduced in C#6.0
Indexer introduced in C#7.0
The Syntax of expression body definition is,

* member => expression;

* where expression should be a valid expression and member can be any from above list of type members.
 
* Suppose we have a method or constructor that contains a single expression or line of code. Then In spite of using the traditional way to write code inside a method or constructor code block, we can write them as a single syntax. Those members who can follow this approach are known as Expression Bodied Members.




#### Deatils
> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
https://www.c-sharpcorner.com/article/expression-bodied-members/

