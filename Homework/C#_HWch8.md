# Programming in C# Chapter 8 Homework
### Thomas Margand
### April 3, 2018

1. What is the difference between deep copy and shallow copy?

A shallow copy just copies a reference to the memory address of whatever is being copied.  A deep copy actually makes a
copy of the content stored in memory allocating a new memory location for the duplicate content.

2. What is the value of a reference after you declare and initialize it?

Nothing, it has no value just an address pointing to an object.

3. How do you declare a value type?

By writing the name of the data type in front of it.

4. How do you declare a reference type?

By creating a new instance of the object being referred.

5. Does C# allow you to assign NULL to a value type?

No, Null is itself a reference so you can not assign null to a value type.

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

No you can not, because if the nullable value type contained a null you would be assigning a non-nullable variable a null value.

7. What is the difference between the stack and the heap?

All value types are created on the stack and references themselves are also stored on the stack although
reference types i.e. the object created is stored on the heap. A stack is akin to a stack of boxes each one containing a value.  The heap is like a room full of boxes, each one has a label. (pg 191)

8. What does it mean when we say all classes are specialized types?

Classes contain the various objects methods and fields that are referenced in programs. Generally they are organized through some type of common sense classification usually functionality.  Therefore classes are a specialized type because they contain various object of similar classification.

9. What does ref do?

If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference to the actual arguments rather than a copy of the argument. When using a ref parameter, anything you do to the parameter you also do to the original argument because the parameter and the argument both reference the same data. (pg 188)

10. What does out do?

The out keyword is syntactically similar to the ref keyword. You can prefix a parameter with the out keyword so that the parameter becomes an alias for the argument. (pg 189)

11. Describe boxing and unboxing in your own words.

A reference must refer to an object on the heap it can not refer back to the stack, therefore if an item refers back to the stack the runtime automatically copies the object stores this copy to the heap and sends the reference to the copy. This is called boxing. Unboxing uses cast to check a reference and make sure the value type matches the value type of the cast before actually referencing it.  If the value types match then the cast is successful and it is called unboxing.

12. What does cast do?

By using cast, you can specify that, in your opinion, the data referenced by an object has a specific type and that it is safe to reference the object by using that type. (pg 196)
