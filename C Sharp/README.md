# Object-oriented Programming
## Table of contents
- [Overloading and Access Modifiers](#overloading-and-access-modifiers)
- [Static](#static)
- [Properties](#properties)

## Overloading and Access Modifiers
### Access Modifiers
- public: The code is accessible for all classes.
- private: The code is only accessible within the same class.
- protected: The code is accessible within the same class, or in a class that is inherited from that class. 

### Ref and Out
- Ref: It is necessary the parameters should initialize before it pass to `ref`.
- Out: It is not necessary to initialize parameters before it pass to `out`.

### Overloading
> In C#, there might be two or more methods in a class with the same name but different numbers, types, and order of parameters, it is called method overloading.

## Static
### Limitation of using static keyword:  
- Static keyword cannot be used by indexers, finalizers, or types other than classes.
- A static member is not referenced through an instance.
- In C#, it is not allowed to use this to reference static methods or property accessors.
- In C#, if static keyword is used with the class, then the static class always contain static members.
### Static Class
- A static class can only contain static data members, static methods, and a static constructor. 
- It is not allowed to create objects of the static class. 
- Static classes are sealed, means one cannot inherit a static class from another class.

### Static Variable
- When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level.
-  Static variables are accessed with the name of the class, they do not require any object for access.

### Static Method
- Static methods are accessed with the name of the class.
- A static method can access static and non-static fields, static fields are directly accessed by the static method without class name whereas non-static fields require objects.

### Static Constructor
- Static Constructor has to be invoked only once in the class and it has been invoked during the creation of the first reference to a static member in the class.
- A static constructor is initialized static fields or data of the class and to be executed only once.

## Properties
Properties are the special type of class members that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they are actually special methods called accessors. This enables data to be accessed easily and helps to promote the flexibility and safety of methods. Encapsulation and hiding of information can also be achieved using properties. It uses pre-defined methods which are “get” and “set” methods which help to access and modify the properties. <br />
There are different types of properties based on the “get” and “set” accessors: <br />
- **Read and Write Properties**: When property contains both get and set methods.
- **Read-Only Properties**: When property contains only get method.
- **Write Only Properties**: When property contains only set method.
- **Auto Implemented Properties**: When there is no additional logic in the property accessors and it introduce in C# 3.0.
### The syntax for Defining Properties:
```
<access_modifier> <return_type> <property_name>
{
        get { return <private_field> }
        set { <private_field> = value }
}
```
Where, <access_modifier> can be public, private, protected or internal. <return_type> can be any valid C# type. <property_name> can be user-defined. Properties can be different access modifiers like public, private, protected, internal. Access modifiers define how users of the class can access the property. The get and set accessors for the same property may have different access modifiers. A property may be declared as a static property by using the static keyword or may be marked as a virtual property by using the virtual keyword. <br />

### Accessor Accessibility 
- We can’t use accessor modifiers on an interface or an explicit interface member implementation.
- We can use accessor modifiers only if the property has both set and get accessors.
- If the property is an override modifier, the accessor modifier must match the accessor of the overridden accessor.
- The accessibility level on the accessor must be more restrictive than the accessibility level on the property.


# Link
- [Object-oriented Programming (OOP)](https://www.techtarget.com/searchapparchitecture/definition/object-oriented-programming-OOP) 
- [C# Access Modifiers](https://www.w3schools.com/cs/cs_access_modifiers.php) 
- [Difference between Ref and Out keywords in C#](https://www.geeksforgeeks.org/difference-between-ref-and-out-keywords-in-c-sharp/) 
- [C# Method Overloading](https://www.programiz.com/csharp-programming/method-overloading) 
- [Static keyword in C#](https://www.geeksforgeeks.org/static-keyword-in-c-sharp/) 
- [C# | Properties](https://www.geeksforgeeks.org/c-sharp-properties/)
- [How to convert a string to a number (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)
