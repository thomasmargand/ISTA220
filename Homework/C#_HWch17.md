# Programming in C# Chapter 17 Homework
### Thomas Margand
### April 10, 2018

1. What is a type parameter?

A generic parameter placeholder to substitute an explicit type declaration.

2. What does a type parameter do?

A type parameter specifies the types of objects on which they operate. (pg373)

3. How many type parameters can a generic class have?

A generic class can have many type parameters with no specified limit.

4. What is the difference between a generic class and a generalized class? (pg 375)

A generic class that uses type parameters is different from a generalized class designed to take parameters
that can be cast to different types. (pg 375)

5. What is a constraint? How do you specify a constraint?

A constraint limits the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces. A constraint is specified when you define a new generic class by using the where keyword to assign a parameter as type IExampleinterface. (pg 375)

6. What is a generic method? How do you define a generic method?

A generic method can specify the types of the parameters and the return type by using a type parameter in a manner similar to that used when you define a generic class. You define generic methods by using the same type parameter syntax you use when you create generic classes. (pg 389)

7. What do we mean when we say that a generic type interface is invariant?

It means that it will not compile as a C# restriction to ensure the type safety of your code. (pg 393)

8. What do we mean when we cay that a generic type interface is covariant?

It means that if the type conversion has been manually checked and ensured for legality you can force it to compile using the out keyword. (pg 394)

9. Does covariance work with value types? Does it work with reference types?

Covariance only works with reference types does not work with value types. (pg 394)

10. What do we mean when we say that a generic type interface is contravariant?

Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A. (pg 395) 
