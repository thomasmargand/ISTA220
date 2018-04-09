# Programming in C# Chapter 11 Homework
### Thomas Margand
### April 7, 2018

1. How do you define a method that takes an arbitrary number of arguments?

By using a parameter array, which is declared by using the params keyword. (pg 246)

2. How do you call a method that takes an arbitrary number of arguments?

As long as the method was defined with the params keyword the method can be called the same way any other method would be called and entering the desired arguments into the method call. (pg 246)

3. Why can't you use an array to pass an arbitrary number of arguments to a method?

The params keyword does not allow the use of multidimensional arrays.  Trying to use an array in conjunction with the params keyword to pass an argument would in effect create a multidimensional array. (pg 246)

4. How many parameters can a method have?

As many as your heart desires (and memory will allow).

5. Do parameter arguments have to have the same type?

No they do not.  By using a parameter array of type object you can declare a method that accepts any number of object arguments, allowing the arguments passed in to be of any type. (pg 247)

6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?

A method that takes optional parameters still has a fixed parameter list, and you can not pass an arbitrary list of arguments. A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value. (pg 252)

7. How do you define a method that takes different (and arbitrary) types of arguments?

You use the params array of object types to create a method that accepts any number of arguments of any type. (pg 254)
