# Programming in C# Chapter 10 Homework
### Thomas Margand
### April 7, 2018

1. What does an array look like in memory?

An array is an unordered sequence of items that live in a contiguous block of memory and are accessed by using an index.
(pg 221)

2. Where is memory allocated to hold an array, on the stack or on the heap?

The memory is allocated on the heap. (pg 222)

3. Where is memory allocated to hold an array reference, on the stack or on the heap?

The memory is allocated on the stack. (pg 222)

4. Can an array hold values of different types? This is a trick question, the answer is "it depends."

5. Describe the syntax of the condition for a foreach loop.

The foreach statement declares an iteration variable that automatically acquires the value of each element in the array. The type of this variable must match the type of the elements in the array. The foreach statement is the preferred way to iterate through an array; it expresses the intention of the code directly, and all of the for loop scaffolding drops away. (pg 226)

6. How do you make a deep copy of an array?

You must use the appropriate code in a for loop statement. (pg 230)

7. What is the difference between a multi-dimensional array and an array of arrays?

A multi-dimensional array is always an even shape and the number of elements is equal to the rows * columns. However an array of arrays or jagged array allows for columns or rows of varying length and does not always result in a symmetric shape. (pg 230)

8. How do you "flatten" a multi-dimensional array? In other words take something that looks like a matrix, and then make it into an array?

You can flatten multi-dimensional arrays by using nested for loops.
