# Virtual Method

* A virtual method is a method that can be redefined in derived classes. 
* A virtual method has an implementation in a base class as well as derived the class. 
* <b>It is used when a method's basic functionality is the same but sometimes more functionality is needed in the derived class. </b>
* A virtual method is created in the base class that can be overriden in the derived class. 
* We create a virtual method in the base class using the virtual keyword and that method is overriden in the derived class using the override keyword.
 
* When a method is declared as a virtual method in a base class then that method can be defined in a base class and it is optional for the derived class to override that method. 
* The overriding method also provides more than one form for a method. Hence it is also an example for polymorphism.
 
* When a method is declared as a virtual method in a base class and that method has the same definition in a derived class then there is no need to override it in the derived class. 
* But when a virtual method has a different definition in the base class and the derived class then there is a need to override it in the derived class.
 
* When a virtual method is invoked, the run-time type of the object is checked for an overriding member. 
* The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.
 


#### Virtual Method in C#
* By default, methods are non-virtual. We can't override a non-virtual method.
* We can't use the virtual modifier with the static, abstract, private or override modifiers. 






#### Details:
> https://www.c-sharpcorner.com/UploadFile/3d39b4/virtual-method-in-C-Sharp/
> https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
> 

