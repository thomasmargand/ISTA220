# Programming in C# Chapter 14 Homework
### Thomas Margand
### March 27, 2018

1. What is the difference between a managed and unmanaged resource?
2. When is memory for an object allocated? When is the memory deallocated?
3. What is a destructor?
4. What is the difference in syntax between a constructor and destructor?
5. Give some examples of scarce resources. Why would you want to manage scarce resources?
6. What is exception safe disposal?

- One way to ensure that a disposal method (such as Close) is always called, regardless of whether there is an exception, is to call the disposal method within a finally block.

7. How do you think the using statement works for resource management? Give an informal English language explanation of how it works.

- The using statement provides a clean mechanism for controlling the lifetime of resources. You can create an object, and this object will be destroyed when the using statement block finishes. The using statement introduces its own block for scoping purposes. This arrangement means that the variable you declare in a using statement automatically goes out of scope at the end of the embedded statement and you can not accidentally attempt to access a disposed resource.

8. What ill effects could result from attempting to dispose of a resource more than once?
9. We will look at threads later in the term. For now what is your understanding of how threads interact with resource management?  A good guess is a sufficient answer to this question.
10. Why does this book not recommend trying to force the garbage collector? Are there any exceptions to this recommendation?
