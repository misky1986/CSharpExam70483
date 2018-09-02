# Chapter 1
## Operators
### Arithmetic operator
1. Add Operator used to add two or more numeric values ```+```
2. Substract Operator used to subtract two or more numeric values ```-```
3. Multiply Operator used to multiply two or more numeric values ```*```
4. Division Operator used to division two or more numeric values ```/```
5. Modulus Operator used to modulus or more numeric values ```%```

### Rational Operators
1. Greater than operator ```>```
2. Smaller than operator ```<```
3. Equal than operator ```==```
4. Not equal operator ```!=```
5. Greater than or equal operator ```>=```
6. Smaller than or equal operator ```<=```

### Bolean Logical Operators
1. **And Operator**, returns **True** if both boolean values are true, otherwise **False**. ```&&```
2. **OR Operator**, returns **True** if one or more of the boolean values are true. If all boolean values are false it returns **False**. ```||```
3. **Not Operator**, negates the boolean values ```!```

## Decision Structures
### The if struture:
```
if(condition)
{
    // Execute code
}
```

### The if-else struture:
```
if(condition)
{
    // If condition met, code insdie this block is executed
}
else
{
    // If condition not met, code insdie this block is executed
}
```

### The if-else-if struture:
When **any condition satisfied**, control will execite code statement written inside its block and skip the remaining else-if and else structures in its chain.

**else** will only get executed, if none of the if and else-if blocks satisfies the conditions in the chain.
```
if(condition)
{
    // If condition met, code insdie this block is executed
}
else if(condition2)
{
    // If condition2 is met, code insdie this block is executed
}
else
{
    // If condition not met, code insdie this block is executed
}
```

### Switch
```
userInput = 1;

switch (userInput)
{
    case "1":
        Addition();
        break;
    case "2":
        Substraction();
        break;
    case "3":
        Multiplication();
        break;
    case "4":
        Division();
        break;
    default:
        WriteCalculatorInformationMessage();
        break;
}
```

## Decision Operators
### Conditional Operator
The conditional operator ```?:``` commonly known as the ternary conditional operator, returns one of two values depending on the value of a Boolean expression.

Following is the syntax for the conditional operator:

```condition ? first_expression : second_expression;```

An a code example:
```
int input = Convert.ToInt32(Console.ReadLine());  
string classify;  

// if-else construction.  
if (input > 0)  
    classify = "positive";  
else  
    classify = "negative";  

// ?: conditional operator.  
classify = (input > 0) ? "positive" : "negative";
```
    
### Null-Coalescing Operator
The ```??``` operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.

An a code example with the null-coalescing operator used:
```
class NullCoalesce
{
    static int? GetNullableInt()
    {
        return null;
    }

    static string GetStringValue()
    {
        return null;
    }

    static void Main()
    {
        int? x = null;

        // Set y to the value of x if x is NOT null; otherwise,
        // if x == null, set y to -1.
        int y = x ?? -1;

        // Assign i to return value of the method if the method's result
        // is NOT null; otherwise, if the result is null, set i to the
        // default value of int, which is zero (0).
        int i = GetNullableInt() ?? default(int);

        string s = GetStringValue();
        // Display the value of s if s is NOT null; otherwise, 
        // display the string "Unspecified".
        Console.WriteLine(s ?? "Unspecified");
    }
}
```

## Loops
### while loop
The ```while``` loop continues as long as the condition is true.

**Syntax example of the while loop**
```
while(condition)
{
    // Code executed while condition is true      
}
```

### do-while loop
The ```do-while``` works the same way as the ```while``` loop, the only different is teh condition always checks at the end.

**Syntax example of the while loop**
```
do
{
    // Code executed while condition is true      
}while(condition)
```

### for loop
The ```for``` statement executes a statement or a block of statements while a specified boolean expression evaluates to ```true```.

**Syntax example of the while loop**
```
for (initializer; condition; iterator)
{
    body
}
```

**An example**
```
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
// Output: 0,1,2,3,4
```

For further reading of the for-loop [Structure of the for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for "Microsoft's Homepage")

## Jump Statements in C#
1. Goto: Transfers control to a labeled statement.
```
label::
// some code
goto label;

OR

goto label;
label:
// some code
```
2. Break: terminates the program flow in the loop or switch statement.
3. Continue: skips the current iteration of the loop and continues with the next iteration.
4. Return: moves back the programn control to the calling method. It returns a value or nothing depending on the nature of method.
5. Throw: Signals the occurrence of an exception during program execution.

## Type Casting
In C# there are two types of typecasting.

1. Implicit Conversion
2. Explicit Conversion

**Implicit Conversion:**
For built-in numeric types, an implicit conversion can be made when the value to be stored can fit into the variable without being truncated or rounded off.
For example, a variable of type long (64-bit integer) can store any value that an int (32-bit integer) can store.

```
// Implicit conversion. A long can hold any value an int can hold, and more!
int num = 2147483647;
long bigNum = num;
```

For a complete list of all implicit numeric conversions, see [Implicit Numeric Conversions Table].
[Implicit Numeric Conversions Table (C# Reference).](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table "Microsoft's Homepage")

**Explicit Conversion**

If a conversion cannot be made without a risk of losing information, the compiler requires that you perform an explicit conversion, which is called a cast.
A cast is a way of explicitly informing the compiler that you intend to make the conversion and that you are aware that data loss might occur.
To perform a cast, specify the type that you are casting to in parentheses in front of the value or variable to be converted.

Below is an example of where a ```double``` is casts to an ```int.```

```
class Test
{
    static void Main()
    {
        double x = 1234.7;
        int a;
        // Cast double to int.
        a = (int)x;
        System.Console.WriteLine(a);
    }
}
// Output: 1234
```

For a list of the explicit numeric conversions that are allowed, see [Explicit Numeric Conversions Table](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/explicit-numeric-conversions-table "Microsoft's Homepage").

## Method
A method is C# consist of a return type, a parameterlist and a method body.

Below is shown the syntax of a method,

```
Type Methodname(Parameter list)
{
    method body
    return type or void;
}
```

### Named Argument
Named arguments free you from the need to remember or to look up the order of parameters in the parameter lists of called methods.
The parameter for each argument can be specified by parameter name.

For example, a function that prints order details (such as, seller name, order number & product name) can be called in the standard way by sending arguments by position, in the order defined by the function.

```PrintOrderDetails("Gift Shop", 31, "Red Mug");```

If you do not remember the order of the parameters but know their names, you can send the arguments in any order.

```PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");```

```PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);```
### Optional Argument
It is possible to set default values in methods and by doing so making them optional.
```
int Sum(int a, int b = 1)
{
    int result = a + b;
    return result;
}

// method calls
sum(19);
// output: 20

sum(19,2);
// output: 21
```

### Pass by reference with ref keyword
When used in a method's parameter list, the ```ref``` keyword indicates that an argument is passed by reference, not by value. The effect of passing by reference is that any change to the argument in the called method is reflected in the calling method
For example, if the caller passes a local variable expression or an array element access expression, and the called method replaces the object to which the ref parameter refers, then the caller’s local variable or the array element now refers to the new object when the method returns.
To use a ref parameter, both the method definition and the calling method must explicitly use the ref keyword, as shown in the following example.

```
void Method(ref int refArgument)
{
    refArgument = refArgument + 44;
}

int number = 1;
Method(ref number);
Console.WriteLine(number);
// Output: 45
```

However, methods can be overloaded when one method has a ref, in, or out parameter and the other has a value parameter, as shown in the following example.

### Pass by reference with out keyword
The ```out``` keyword causes arguments to be passed by reference.
It is like the ref keyword, except that ref requires that the variable be initialized before it is passed.
It is also like the in keyword, except that in does not allow the called method to modify the argument value.
To use an out parameter, both the method definition and the calling method must explicitly use the out keyword.

For example:
```
int initializeInMethod;
OutArgExample(out initializeInMethod);
Console.WriteLine(initializeInMethod);     // value is now 44

void OutArgExample(out int number)
{
    number = 44;
}
```

Variables passed as out arguments do not have to be initialized before being passed in a method call.
However, the called method is required to assign a value before the method returns.

Although the in, ref, and out keywords cause different run-time behavior, they are not considered part of the method signature at compile time.

# Exam Questions:
## Question 1
Whcih of the following methods help us to convert string type data into integers? Select any two.
  
A) Convert.ToInt32()

B) Convert.Int32()

C) int.Parse()

D) parse.int();

**Answer: A and C.**

The book has a error and write option A as Convert.toInt32() which is wrong. It is with capital T.

## Question 2
Suppose you're implementing a method name "Show" that will be able to take an unlimited number of int arguments.
How are you going to define its method signature?
  
A) void Show(int[] arg)

B) void Show(params int[] arg)

C) void Show(int a)

D) void Show(ref int a)

**Answer: B**

## Question 3
You're developing an application that saves user's information. The application includes the following
code segment (line numbers included for reference)

```
01 public bool IsNull(string name)
02 {
03      return true;
04 }
```

You need to evaluate whether a name is null.
Which code segment should you insert at line 03.
  
A)
```
if(name = null)
{
    return true;
}
```

B)
```
if(name == null)
{
    return true;
}
```

C)
```
if(null)
{
    return true;
}
```

D)
```
if(!name)
{
    return true;
}
```

**Answer: B**

## Question 4
You nned to use null-coalescing operator to make sure "name" variable must have a value not null.
Select the right way to use null.coalescing operator in C#.
  
A)
```
string name = n ?? "No Name";
```

B)   

```
string name = "No Name" ?? null;
```

C)
```
string name = "No Name" ? null;
```

D)
```
string name = null ? "No Name";
```
**Answer: A**

## Question 5
Which jump statement will you use to start the next iteration while skipping the current iteration of loop?
A) Break

B) Continue

C) Goto

D) Return

**Answer: B**