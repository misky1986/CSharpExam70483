# Chapter 3 - Object Oriented Programming

## Access Specifiers
Access specifiers are special keywords, used to define the accessibility level of a type (class, struct, enum)
and all of the data members and methods defined inside it.

```Public:```
  * Members defined with public access specifiers are accessible within the class as well as outside the class.

```Private```
  * Members defined with private access specifiers are only accessible within the class and they cannot be
accessed from outside the class.

```Protected```
  * Members defined with protected access specifiers are accessible within the class and also within its child
classes. They cannot be accessible from outside the class.

```Internal```
  * members defined with internal access specifiers are accessible within
    the class as well as outside the class. But they are not accessible to any class which is defined outside the
    project’s assembly.

```Internal Protected ```
  * Members defined with internal protected access specifiers are accessible within as
    well as outside the class and also to its child classes. But they aren’t accessible to any class which is defined
    outside the project’s assembly scope.

## Data Protection
In C#, data is stored in a single variable or in an array.
To protect this data from accidental damage.

### Properties
Properties are used to encapsulate the value of a private field. They use access specifiers, which gives better
control to read, write, or manipulate a field’s value.

#### Full Property
In full property, we declare private fields and encapsulate them inside a property’s definition.

Definition of an Full Property
```
class Student
{
    private int age;
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}
```

Usage of a Full Property
```
class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        std.Age = 10;
    }
}
```
#### Auto Property
Auto property is a lot like full property. The only key difference is, it doesn’t require any field or extra logic in
its get and set to manipulate values, because a compiler creates its own private field automatically. It’s just a
syntactic sugar.

Definition of a Full Property
```
class Student
{
    public int Age { get; set; }
}
```
Usage of a Full Property
```
class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        std.Age = 10;
    }
}
```
### Indexers
Definition of an index method that encapsulate weekTemp array temperatures.
```
class Temprature
{
    //declare private array of float type.
    private float[] weekTemp = { 47.5F, 40.0F, 52.5F, 45.5F, 48.0F, 38.0F, 35.7F };
    //use float indexer, to encapsulate weekTemp
    public float this[int index]
    {
        get
        {
            return weekTemp[index];
        }
        set
        {
            weekTemp[index] = value;
        }
    }
}
```

Usage of indexer method in a C# program.
```
class Program
{
    static void Main(string[] args)
    {
        Temprature temp = new Temprature();
        float todayTemp = temp[1]; //read
        temp[1] = -5.0F; //Write
    }
}

```

## Inheritance
Inheritance is one of the three fundamental pillars of object-oriented programming. It allows classes to
reuse or inherit properties and methods from an existing class.

### Abstract Class
Abstract classes cannot be instantiated. It is used as base class, where it provides common members to all
its derived classes. It is either overridden partially or not at all. It is also used to declare abstract methods
(method without definition) that when it inherits, it must be overridden by its derived classes.

The class below is abstract because it contains a method that is abstract.
This means that all derived classes need to implement this method in order to use the class.

```
public abstract class Vehicle
{
    public int Wheels { get; set; }
    public int Speed { get; set; }

    public abstract void Run();
}
```

Derived class
```
public class Car : Vehicle
{
    public override void Run()
    {
        base.Wheels = 4;
        base.Speed = 350;

        Console.WriteLine($"The chosen vehicle is a {this.GetType().Name} with {base.Wheels} wheels and a max speed of {base.Speed}");
    }
}
```

Usage
```
Vehicle vehicle = null;
switch (vehicleAbility)
{
    case Ability.Air:
        Console.Write("Air Vehicle chosen.\n");
        vehicle = new Jet();
        vehicle.Run();
        break;
    case Ability.Road:
        Console.Write("Road Vehicle chosen.\n");
        vehicle = new Car();
        vehicle.Run();
        break;
    case Ability.Water:
        Console.Write("Water Vehicle chosen.\n");
        vehicle = new Boat();
        vehicle.Run();                        
        break;
    default:
        break;
}
```

### Interface
Interface cannot be instantiated. Its members have no implementation detail. All implementation detail is
defined by classes which implement (inherit) interfaces. Interface provides the highest level of abstraction.

#### Implement Interface
**Implicitly**

**Explicitly**

Explicit interfaces are implemented privately. We implement them explicitly when a separate definition of
each interface’s member is required

Definition and explicit implementation.
```
interface IEnglish
{
    int Marks { get; }
}

interface IMath
{
    int Marks { get; }
}

class Student : IEnglish, IMath
{
    int english = 10;
    int math = 9;
    int IMath.Marks
    {
        get
        {
            return english;
        }
    }

    int IEnglish.Marks
    {
        get
        {
            return math;
        }
    }
}
```

Usage

```
class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        int english = ((IEnglish)std).Marks;
        int math = ((IMath)std).Marks;
        Console.WriteLine("English Marks = {0} Math Marks = {1}",
        english, math);
    }
}
```

## Polymorphism
Polymorphism is all about changing behaviors; in other words, it is different forms of one object.

### Static Polymorphism
Static polymorphism means changing behavior of methods at compile time, it is also known as early binding.
In C#, static polymorphism can be implemented with two ways.

#### Method Overloading
Inside type (class, struct) definition we can have multiple methods of the same name but with different
parameters; this is called method overloading.

A method can be overloaded in two ways which are:
* By paramter types in the method signiture
* By the lenght of the parameter list

Method overloaded by length of the parameter list
```
public void Add(int a)
{
    string result = a.ToString();
    Console.WriteLine("Sum of strings = {0}", result);
}

public void Add(int a, int b)
{
    int result = a + b;
    Console.WriteLine("Sum of ints = {0}", result);
}
```
Method overloaded by the type of the method signature.
```
public void Add(int a, int b)
{
    int result = a + b;
    Console.WriteLine("Sum of ints = {0}", result);
}

public void Add(string a, string b)
{
    string result = a + b;
    Console.WriteLine("Sum of strings = {0}", result);
}
```

#### Operator Overloading
In C#, we can overload the definition of an operator for custom types (class, struct).
Generally, in C# we can overload three kinds of operators:
* Unary operators
* Binary Operators
* Comparison Operators
 
##### Unary operators
The unary operators are the following: ```+, -, !, ++, --, true, false```

Signature of unary operator overloading
```
public static return_type operator op (Type t)
{
    // Implementation
}
```

Example of overlaoded ++ operator
```
class Distance
{
    public int meter { get; set; }
    public static Distance operator ++ (Distance dis )
    {
        dis.meter += 1;
        return dis;
    }
}
```

Usage of overloaded ++ operator
```
class Program
{
    static void Main(string[] args)
    {
        Distance distance = new Distance();
        distance.meter = 5;
        distance++;
        Console.WriteLine(distance.meter);
    }
}
```

##### Binary Operators
The binary operators are the following: ```+, -, *, /, %, &, |, ^, <<, >>```

Signature of unary operator overloading
```
public static return_type operator op (Type1 t1, Type2 t2)
{
    // Implementation
}
```

Example of overlaoded + operator
```
class Student
{
    public int Marks { get; set; }
    // + Operator Overloading Method
    public static Student operator + (Student s1, Student s2)
    {
        Student std = new Student();
        std.Marks = s1.Marks + s2.Marks;
        return std;
    }
}
```

Usage of overloaded + operator
```
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student { Marks = 10 };
        Student s2 = new Student { Marks = 20 };
        Student s3 = s1 + s2;
        Console.WriteLine(s3.Marks);
    }
}
```

##### Comparison Operators

The comparison operators are the following: ```==, !=, <, >, <=, >=```

Signature of comparison operator overloading
```
public static bool operator op (Type1 t1, Type2 t2)
{
    //Implementation
}
```

Example of overlaoded < and > operator
```
class Distance
{
    public int meter { get; set; }
    public static bool operator < (Distance d1, Distance d2 )
    {
        return (d1.meter < d2.meter);
    }
    public static bool operator > (Distance d1, Distance d2)
    {   
        return (d1.meter > d2.meter);
    }
}
```

Usage of overloaded < and > operator
```
class Program
{
    static void Main(string[] args)
    {
        Distance d1 = new Distance { meter = 10 };
        Distance d2 = new Distance { meter = 20 };
        if(d1 < d2)
        {
            Console.WriteLine("d1 is less than d2");
        }
        else if(d2 < d1)
        {
            Console.WriteLine("d2 is less than d1");
        }
    }
}
```

### Dynamic Polymorphism
Polymorphism in programming is all about changing behavior, while dynamic polymorphism means
changing behavior of an object at runtime by overriding the definition of a method.
It is also known as late binding.

#### Virtual Method
Virtual is a keyword used with method in base class to define a virtual method. Virtual method has a
definition of its method; its derived class can inherit or override its definition. Thus, when calling the
method name the runtime will determine which method to invoke.

#### Abstract Method
Abstract is a keyword used with method in abstract class to declare an abstract method. Unlike virtual
method, abstract method doesn’t have its definition of method. Thus, its derived class must implement the
definition of abstract method, otherwise compile time error will generate. Abstract methods always declare
inside an abstract class.

## Exam Questions
1) A and B
2) 
3) B
4) B
5) A