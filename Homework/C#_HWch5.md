# Programming in C# Chapter 5 Homework
### Thomas Margand
### March 6, 2018


1. What is a compound assignment operator? How does it work?

A compound assignment operator is a combination of any arithmetic operator and the assignment operator '='. It works by performing the stated arithmetic operation with whatever value is assigned to the variable.  An example would be 'answer += 42'.  This would increase the value of answer by 42.     

2. List all the compound assignment operators.

 - variable \*= number;
 - variable /= number;
 - variable %= number;
 - variable += number;
 - variable -= number;

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.

 - answer = answer + 5
 - answer += 5

 - answer = answer - 50
 - answer -= 50

4. How long does a while loop run?

A While loops runs until the boolean expression defined evaluates to false.

5. What happens if you don't change the loop variable in the body of the while loop block?

If you don't change the loop variable in the body of the while loop block then the while loop will run forever.

6. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?

A for loop statement has three parts any of which can be omitted.  If you omit all three parts of a for loop statement it generates and infinite loop.

7. How do you guarantee that a loop runs at least once?

Using a do statement, which evaluates the boolean expression at the end of the loop, guarantees that the loop runs at least once.

8. What does the break statement do?

A break statement jumps out of the body of an iteration statement.  It breaks out of the loop and begins executing the first statement that follows the loop.  

9. What does the continue statement do?

The continue statement causes the program to perform the next iterations of the loop immediately.
