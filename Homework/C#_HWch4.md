# Programming in C# Chapter 4 Homework
### Thomas Margand
### March 6, 2018


1. What are all possible values of a Boolean expression?

In the context of the C# programming language the only possible values for a Boolean expression are true or false.

2. List eight Boolean operators.

 - == is an equality operator meaning equal to, not to be confused with the assignment operator =
 - != is equality operator meaning not equal to
 - < is a relational operator meaning less than
 - <= is a relational operator meaning less than or equal to
 - ">" is a relational operator meaning greater than
 - ">=" is a relational operator meaning greater than or equal to
 - && is a conditional logic operator meaning AND
 - || is a conditional logic operator meaning OR

3. What are the differences in how short circuiting works for && and ||?

In order for the &&  operator to short circuit the left operand has to evaluate to false.  In order for the || operand to short circuit the left operand has to evaluate to true.

4. Look at the list of operators. What operator has the highest precedence? Which has the lowest?

Within the list of Boolean operators the relational operators have the highest precedence followed by the equality operators and finally the conditional logic operators have the lowest precedence. However within the context of all operators that we have learned so far Primary operators have the highest precedence and Assignment operators have the lowest.

5. In an if else construction using multiple lines of code, what effect does the use of curly braces have?

It creates a block, a sequence of statements. A block also starts a new scope that allows for the creation of new variables, however they will disappear at the end of the block.

6. In a switch statement, what happens if you omit break?

If the break is omitted and followed by a statement the code will not compile and will generate an error.  However, if the break is omitted and followed by another case label fall through will be allowed and the code will execute the statement for all cases in that list.  
