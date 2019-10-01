# C# | Arrays


### Important Points to Remember About Arrays in C#

* In C#, all arrays are dynamically allocated.
* Since arrays are objects in C#, we can find their length using member length. This is different from C/C++ where we find length using sizeof.
* A C# array variable can also be declared like other variables with [] after the data type.
* The variables in the array are ordered and each has an index beginning from 0.
* C# array is an object of base type System.Array.
* Default values of numeric array and reference type elements are set to be respectively zero and null.
* A jagged array elements are reference types and are initialized to null.
* Array elements can be of any type, including an array type.
* Array types are reference types which are derived from the abstract base type Array. These types implement IEnumerable and for it, they use foreach iteration on all arrays in C#.

```csharp
    int[] x;  // can store int values
    string[] s; // can store string values
    double[] d; // can store double values
    Student[] stud1; // can store instances of Student class which is custom class
```


### Jagged Arrays
* An array whose elements are arrays is known as Jagged arrays it means “array of arrays“. The jagged array elements may be of different dimensions and sizes. Below are the examples to show how to declare, initialize, and access the jagged arrays.
* Jagged array is a array of arrays such that member arrays can be of different sizes.

### Points To Remember
* GetLength(int): returns the number of elements in the first dimension of the Array.
When using jagged arrays be safe as if the index does not exist then it will throw exception which is IndexOutOfRange.



