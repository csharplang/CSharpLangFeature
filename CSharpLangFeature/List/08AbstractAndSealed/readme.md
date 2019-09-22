# Abstract and Sealed Classes

* The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.

* The sealed keyword enables you to prevent the inheritance of a class or certain class members that were previously marked virtual.


# Abstract Class
* An abstract class is an incomplete class or special class we can't be instantiated.
* Abstraction in C# is the process to hide the internal details and showing only the functionality. 
* The abstract modifier indicates the incomplete implementation. The keyword abstract is used before the class or method to declare the class or method as abstract. Also the abstract modifier can be used with indexers, events and properties.

#### Important Points:
1. Generally, we use abstract class at the time of inheritance.
1. A user must use the override keyword before the method which is declared as abstract in child class, the abstract class is used to inherit in the child class.
1. An abstract class cannot be inherited by structures.
1. It can contains constructors or destructors.
1. It can implement functions with non-Abstract methods.
1. It cannot support multiple inheritance.
1. It can’t be static.

#### Abstract Class Features
1. An abstract class can inherit from a class and one or more interfaces.
1. An abstract class can implement code with non-Abstract methods.
1. An Abstract class can have modifiers for methods, properties etc.
1. An Abstract class can have constants and fields.
1. An abstract class can implement a property.
1. An abstract class can have constructors or destructors.
1. An abstract class cannot be inherited from by structures.
1. An abstract class cannot support multiple inheritance.



### Sealed Classes
* Restrict the users from inheriting the class. 
* Cannot be extended. No class can be derived from a sealed class.
* But you can create an instance of led Class.
* A method can also be sealed, and in that case, the method cannot be overridden.


### Why Sealed Classes?
* Sealed class is used to stop a class to be inherited. You cannot derive or extend any class from it.
* Sealed method is implemented so that no other class can overthrow it and implement its own method.
* The main purpose of the sealed class is to withdraw the inheritance attribute from the user so that they can’t attain a class from a sealed class. 
* Sealed classes are used best when you have a class with static members.
e.g the “Pens” and “Brushes” classes of the System.Drawing namespace. The Pens class represents the pens for standard colors. This class has only static members. For example, “Pens.Red” represents a pen with red color. Similarly, the “Brushes” class represents standard brushes. “Brushes.Red” represents a brush with red color. 

