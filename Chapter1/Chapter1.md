# Chapter 1


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