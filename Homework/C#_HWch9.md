# Programming in C# Chapter 9 Homework
### Thomas Margand
### April 7, 2018

1. Declare an enum for military ranks either officer or enlisted. Name it ranks. What are the symbols, like private, PFC, Coroporal, 2LT, 1LT, Capt?

`enum Ranks {PV1, PV2, PFC, SPC, SGT, SSG, SFC, 1SG, SGM}`

2. Using the ranks enum assign a rank to yourself or a friend.

`Ranks Thomas = Ranks.SGT;`

3. Determine the numeric index of particular ranks, using the Ranks enum.

`ConsoleWriteLine((int)enum Ranks);`

4. How do you select the type of an enum?

`enum Ranks : short {PV1, PV2, PFC, SPC, SGT, SSG, SFC, 1SG, SGM}`

5. Are structs stored on the stack or the heap? What about enums?

A struct is a value type and thus stored on the stack. An enum is a type as well and thus stored on the stack.

6. Declare a struct named DOD with 4 branches.

`struct DOD
{
  public string Army, Navy, Airforce, Marines;
}`

7. Why can't you create a default constructor for a struct?

The reason you cant declare your own default constructor for a structure is that the compiler always generates one. In a class, the compiler generates the default constructor only is you don't write a constructor yourself. (pg 209)

8. What is CIL? What does the CLR do to the CIL?

CIL is the common intermediate language and it is the language the compiler converts C# code into.  The CLR (common language runtime) then converts this to real machine instructions that the processor on your computer can understand and execute. (pg 218)
