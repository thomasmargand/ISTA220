# Programming in C# Chapter 2 Homework
### Thomas Margand
### February 20, 2018


1. What is a local variable? 	

A Local variable is any variable you declare inside the body of a method that are scoped to that method. They disappear when the method ends and can be accessed only by code running in that method.

2. What is a statement?

A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to the user.

3. What is an identifier?

Identifiers are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.

4. What is a variable?

A variable is a storage location that holds a value.

5. What is a method?

A method is a named sequence of statements; it is similar to a function or subroutine.

6. Are primitive types and value types the same thing? See page 177.

No. Primitive types are a form of value types, the opposite is not true.

7. How are the arithmetic operators and variable types related?

Not all arithmetic operators can be used on all variable types. Certain arithmetic operators can be used on certain variable types.

8. How do you turn an integer into a string?

Using the ToString method converts an integer into a string.

9. How do you turn a string into an integer?

Using the int.Parse method converts a string into an integer.

10. What is the difference between precedence and associativity? Give an example where this makes a difference.

In the context of C# precedence is given to multiplicative and divisive operators over additive and subtractive operators. Thus within a given arithmetic operation multiplication and division operations will be performed first, before addition and subtraction, regardless of the order in which they appear in the code. When presented with operators of the same type, multiplication and division or addition and subtraction, the operations are performed in the order they are written from left to right, this is known as associativity. In the example 2 + 3 * 4 / 2, the multiplication must be performed first, then the division and finally the addition resulting in an answer of 8.

11. What is the definite assignment rule?

The definite assignment rule states that you must assign a value to a variable before you can use it; otherwise, your program will not compile.

12.	How are the prefix and postfix increment and decrement operators evaluated differently?

The prefix form performs the operation before evaluating the value of a variable. The postfix form evaluates the variable before performing the operation.

13. What is the string interpolation?

String interpolation is a feature of C# that allows strings to be concatenated without the use of the + operator. The strings to be concatenated are combined by preceding with a $ and containing the second string within curly brackets. This feature is less memory hungry, more readable, and less error prone.   

14.	What does the var keyword do?

When you declare a variable in C# by using the var keyword, the type of values that you assign to the variable cannot change from that used to initialize the variable.

Homework Notes
 - A variable is a named location in memory that contains a value.
 - A method is a named location in memory that references a behavior.
