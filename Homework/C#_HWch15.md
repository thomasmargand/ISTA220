# Programming in C# Chapter 18 Homework
### Thomas Margand
### April 16, 2018

1. What is the difference between a property and a field?

A property is a cross between a field and a method. It looks like a field, but acts like a method. You access a property by using exactly the same syntax that you use to access a field. However, the compiler automatically translates this field like syntax into calls to accessor methods. (pg 331)

2. What is the difference between a property and a method?

A property is a cross between a field and a method. It looks like a field, but acts like a method. You access a property by using exactly the same syntax that you use to access a field. However, the compiler automatically translates this field like syntax into calls to accessor methods. (pg 331)

3. What is your understanding of encapsulation?

The two purposes of encapsulation are to combine methods and data within a class; in other words, to support classification and to control the accessibility of the methods and data; in other words, to control the use of the class. (pg 154)

4. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?

In my limited experience with coding I have found this very issue to be a source of great frustration in creating and editing code.  Particularly when moving between code that is case sensitive like C# and code that is not case sensitive like SQL.  Using only case to differentiate identifiers can be a significant source of errors in code that are difficult to find.  It also can also make the code more difficult to read an understand.  I avoid this practice when writing code.

5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use a write-only
property.

A read only property will be useful in any instance you want to be able to see a property, but not modify it such as a constant that will be used by multiple elements of a program.  Write only properties are most useful for security measures such as passwords or anything else that requires an input, but should not be read back or accessible to be read back by the user.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.

I can not think of an instance where both getters and setters should be private, if they were both private the element would be inaccessible.  The only possible instance I could think of (which I am fairly certain would not work) is if you were trying to hide a feature or element of a program, such as an Easter egg in a video game.  Likewise I can not mount a meaningful defense for always making them both public except in instances where security is not an issue.

7. What are restrictions on the use of properties?

You can assign a value through a property of a structure or class only after the structure or class has been initialized. You can't use a property as a ref or an out argument to a method. A property can contain at most one get accessor and one set accessor and those accessors can not take any parameters. You can't declare properties by using const. (pg 336)

8. What is an object initializer? What is the syntax for an object initializer?

When you create an instance of a class, you can initialize it by specifying the names and values for any public properties that have set accessors. This syntax is known as an object initializer. When you invoke an object initializer in this way, the C# compiler generates code that calls the default constructor and then calls the set accessor of each named property to initialize it with the value specified. (pg 347)
   
