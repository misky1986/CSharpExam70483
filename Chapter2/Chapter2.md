# Chapter 2
## Types
There are two kinds of types in C#: reference types and value types.
Variables of reference types store references to their data (objects), while variables of value types directly contain their data.
With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable.
With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in the case of in, ref and out parameter variables; see in, ref and out parameter modifier).

The C# typing system contains the following categories:

* [Value types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types "Microsoft Homepage")
* [Reference types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types "Microsoft Homepage")

Variables that are value types store data, and those that are reference types store references to the actual data.
Reference types are also referred to as objects. Pointer types can be used only in unsafe mode.

It is possible to convert a value type to a reference type, and back again to a value type, by using [boxing and unboxing](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing).
With the exception of a boxed value type, you cannot convert a reference type to a value type.

### Value Types
The value types consist of two main categories:

* Structs
* Enumerations

Structs fall into these categories:

* Numeric types
  * Integral types
  * Floating-point types
* bool
* User defined structs.

#### Main Features of Value Types
Variables that are based on value types directly contain values. Assigning one value type variable to another copies the contained value. This differs from the assignment of reference type variables, which copies a reference to the object but not the object itself.

All value types are derived implicitly from the System.ValueType.

Unlike reference types, a value type cannot contain the ```null``` value. However, the [nullable types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/nullable-types/index) feature does allow for value types to be assigned to ```null```.

Each value type has an implicit default constructor that initializes the default value of that type.

  Value type        | Default value           
| -------------     |:-------------:| 
| bool              | right-aligned                                                                                                         |       
| byte              | centered                                                                                                              |       
| bool	            | false                                                                                                                 |
| byte              | 0                                                                                                                     |
| char              | '\0'                                                                                                                  |
| decimal           | 0M                                                                                                                    |
| double            | 0.0D                                                                                                                  |
| enum              | The value produced by the expression (E)0, where E is the enum identifier.                                            |
| float             | 0.0F                                                                                                                  |
| int               | 0                                                                                                                     |
| long              | 0L                                                                                                                    |
| sbyte             | 0                                                                                                                     |
| short             | 0                                                                                                                     |
| struct            | The value produced by setting all value-type fields to their default values and all reference-type fields to null.    |
| uint              | 0                                                                                                                     |
| ulong	            | 0                                                                                                                     |
| ushort	        | 0                                                                                                                     |

### Reference Types

The following keywords are used to declare reference types:
* class
* interface
* delegate

C# also provides the following built-in reference types:
* dynamic
* object
* string

#### Class
A class is used to encapsulate the attribute and behavior of an entiry. It supports object-oriented principles.
Therefore classes is especially good for defining complex classes.

```
<scope> class <class-name>
{
    // Fields
    // Properties
    // Constructors
    // Methods
    // Events
    // Delegates
    // Nested classes
}
```

#### Constructors
Constructors is a method, called and executed first by untime soon after it's type's instance is created on memory.
It doen't have a return type. It is used to initialize data membersa that protect the application from any garbage computation error.

#### Base constructors
Classes may have many derived classes.- A drived class inherits attributes and methods of its base class.
If a base has a parameterized constructor, its derived class must pass values to initialize its base class's constructor
```
class DerivedClass : BaseClass
{
    public DerivedClass(type x) : base(type x)
    {
    }
}
```

* ```base``` it calls and passes values to a parameterized constructor of the BaseClass
* Derived class constructor at least has the same parameters of the BaseClass's constructor. Therefore, it could pass value to its base class's constructor.


#### Static Type
Unlike normal classes, static classes **cannot be instantiated**. They're useful to define helper static methods.
Static classes doesn't have any instance member. All **members must be static** in a static class. Therefore, members of static classes can be **accesd by using the class name itself**.

To define a static class use the ```static``` keyword.

```
static class MyStaticClass
{
    public static void MySuperDuperStaticHelperMethod()
    {
    }
}
```

#### Static constructors
Unlike normal classes, static classes **doesn't contain public instance constructor**. It 
**contains a private static constructor** to initialize static members. It is **called automatically** before the first instance is created or any static members are referenced.

### Extension Methods
Extension methods are special static methods that can inject additional methods without changing, deriving or recompiling the origional type.
They are always called as they were instance methods.

* Extension methods are always defined inside **static classes**
* The first parameter of extension methods must have ```this``` operator, which tells whose instance this extension method should give access fore.
* The extension method should be defined in the same namespace in which it is used, or import the namespace in which the extension method was defined. 

### Type Conversion
Conversion of one type to another is called **type conversion**. Type conversion has three forms:
* Implicit Type Conversion
* Explicit Type Conversion
* User Defined Type Conversion

#### Implicit Type Conversion
If one type converts into another type automatically, it's called implicit type conmversion. This is done by the compiler automatically. A common example is conversion of derived classes to a base class.

```
class A {}
class B : A {}
A a = new B();
```

#### Explicit Type Conversion
If one type **needs special syntax** to convert it into another type, it's called explicit conversion.
This is done by the **programmer**. A common example is conversion of a base class to a derived class.

Explicit type conversion is done in two ways:
* With the ```as``` keyword
* Type-value with the ```is``` keyword

#### as operator
You can use the as operator to perform certain types of conversions between compatible reference types or nullable types.
```
class Base
{
    public override string  ToString()
    {
        return "Base";
    }
}
class Derived : Base 
{ }

class Program
{
    static void Main()
    {

        Derived d = new Derived();

        Base b = d as Base;
        if (b != null)
        {
            Console.WriteLine(b.ToString());
        }

    }
}
```
The ```as``` operator is like a cast operation. However, if the conversion isn't possible, ```as``` returns ```null``` instead of raising an exception.
Note that the ```as``` operator performs only reference conversions, nullable conversions, and boxing conversions. The ```as``` operator can't perform other conversions, such as user-defined conversions, which should instead be performed by using cast expressions.

#### is 
Checks if an object is compatible with a given type, or (starting with C# 7.0) tests an expression against a pattern.

#### Testing for type compatibility
The ```is``` keyword evaluates type compatibility at runtime. It determines whether an object instance or the result of an expression can be converted to a specified type.
It has the syntax:

```expr is type```

where expr is an expression that evaluates to an instance of some type, and type is the name of the type to which the result of expr is to be converted
The ```is``` statement is ```true``` if expr is non-null and the object that results from evaluating the expression can be converted to type; otherwise, it returns ```false```.

**The is statement is true if:**
* expr is an instance of the same type as type.
* expr is an instance of a type that derives from type. In other words, the result of expr can be upcast to an instance of type.
* expr has a compile-time type that is a base class of type, and expr has a runtime type that is type or is derived from type. The compile-time type of a variable is the variable's type as defined in its declaration. The runtime type of a variable is the type of the instance that is assigned to that variable.
* expr is an instance of a type that implements the type interface.

Example of using is operator:
```
using System;

public class Class1 : IFormatProvider
{
   public object GetFormat(Type t)
   {
      if (t.Equals(this.GetType()))      
         return this;
      return null;
   }
}

public class Class2 : Class1
{
   public int Value { get; set; }
}

public class Example
{
   public static void Main()
   {
      var cl1 = new Class1();
      Console.WriteLine(cl1 is IFormatProvider);
      Console.WriteLine(cl1 is Object);
      Console.WriteLine(cl1 is Class1);
      Console.WriteLine(cl1 is Class2); 
      Console.WriteLine();
 
      var cl2 = new Class2();
      Console.WriteLine(cl2 is IFormatProvider);
      Console.WriteLine(cl2 is Class2);
      Console.WriteLine(cl2 is Class1);
      Console.WriteLine();
      
      Class1 cl = cl2;
      Console.WriteLine(cl is Class1);
      Console.WriteLine(cl is Class2);
   }
}
// The example displays the following output:
//     True
//     True
//     True
//     False
//     
//     True
//     True
//     True
//     
//     True
//     True
```

#### User defined Type Conversion
C# allows users to provide the definition of **conversion for their custom types**.
It's definition is similar to operator overloadings definition.

**User defined conversion is of two kinds**
* Implicit User Defined Conversion
* Explicit User Defined Conversion

#### Implicit User Defined Conversion
A user can define an implicit conversion definition in a type that helps to convert it into another type.
Immplicit conversion occurs automatically.
For implicit conversion, a special **static method** is defined with an **implicit and operator keyword** inside the type definition.
```
class MyClass
{
    public static implicit operator returnType(Type t)
    {
    }
}
```
* **returnType** tells which type of data would get returned in implicit conversion.
* **type t** tells which type of data would get converted implicity.

Example of usage:
```
class Digit
{
    public Digit(double d) { val = d; }
    public double val;
    // ...other members

    // User-defined conversion from Digit to double
    public static implicit operator double(Digit d)
    {
        return d.val;
    }
    //  User-defined conversion from double to Digit
    public static implicit operator Digit(double d)
    {
        return new Digit(d);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Digit dig = new Digit(7);
        //This call invokes the implicit "double" operator
        double num = dig;
        //This call invokes the implicit "Digit" operator
        Digit dig2 = 12;
        Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);
        Console.ReadLine();
    }
}
```

#### Exlicit User Defined Conversion
A user can define an explicit conversion definition in a type that helps to convert it into another type.
Casting is required to convert a type into another. DAta can be lost in explicit conversion.
For explicit conversion, a special **static method** is defined with an **explicit and operator keyword** inside the type definition.
```
class MyClass
{
    public static explicit operator returnType(Type t)
    {
    }
}
```

* **returnType** tells which type of data would get returned in implicit conversion.
* **type t** tells which type of data would get converted implicity.

The following example defines the operator that converts from a Fahrenheit class to a Celsius class.
The operator must be defined either inside a Fahrenheit class or a Celsius class:
```
public static explicit operator Celsius(Fahrenheit fahr)
{
    return new Celsius((5.0f / 9.0f) * (fahr.Degrees - 32));
}

Fahrenheit fahr = new Fahrenheit(100.0f);
Console.Write($"{fahr.Degrees} Fahrenheit");
Celsius c = (Celsius)fahr;
```
