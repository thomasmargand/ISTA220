# Programming in C# Chapter 16 Homework
### Thomas Margand
### April 10, 2018

1. Give 5 examples (using valid C# code) of the five bitwise operators listed in the text.

 - The NOT operator (~)
 - The left shift (<<) operator
 - The OR (|) operator
 - The AND (&) operator
 - The XOR (^) operator

2. Does C# implement the right shift operator (>>)?  If, so give an example of its operation using valid C# code.

There is a right shift operator and it works in the same way as the left shift operator.

3. Explain in detail this code bits & (1 << index);.

A boolean expression that returns true if variable bits and 1 left shift of the index equal each other.

4. Explain in detail this code bits |= (1 << index);.

A boolean expression that returns true regardless if variable bits and 1 left shift of the index equal each other.

5. Explain in detail this code bits &= (1 << index);.

A boolean expression that returns true if variable bits and 1 left shift of the index equal each other.

6. How does C# interpret this code bool peek = bits[n];.

This will display either a 1 or 0 depending on the value of n.

7. How does C# interpret this bits[n] = true;

Sets the value of the index at n to true.

8. How does C# interpret this bits[n] ^= true;

Sets the value of the index at n to false.

9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0 none
(b) permission = 1 read
(c) permission = 2 write
(d) permission = 3 read & write
(e) permission = 4 execute
(f) permission = 5 read & execute
(g) permission = 6 write & execute
(h) permission = 7 read, write & execute

10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this shceme of permissions?
