# Object-oriented Programming
## Table of contents
- [OOP](#oop)
- [Overloading and Access Modifiers](#overloading-and-access-modifiers)
- [Static](#static)
- [Properties](#properties)
## OOP
### Structure of object-oriented programming
- **Classes** are user-defined data types that act as the blueprint for individual objects, attributes and methods. <sub>Vehicle</sub>
- **Objects** are instances of a class created with specifically defined data. Objects can correspond to real-world objects or an abstract entity. When class is defined initially, the description is the only object that is defined. <sub>car, motorcycle, bicycle</sub>
- **Methods** are functions that are defined inside a class that describe the behaviors of an object. Each method contained in class definitions starts with a reference to an instance object. Additionally, the subroutines contained in an object are called instance methods. Programmers use methods for reusability or keeping functionality encapsulated inside one object at a time. <sub>Drive(), Brake(), Refuel()</sub>
- **Attributes** are defined in the class template and represent the state of an object. Objects will have data stored in the attributes field. Class attributes belong to the class itself. <sub>weight, color</sub>

### The main principles of OOP
- **Encapsulation.** This principle states that all important information is contained inside an object and only select information is exposed. The implementation and state of each object are privately held inside a defined class. Other objects do not have access to this class or the authority to make changes. They are only able to call a list of public functions or methods. This characteristic of data hiding provides greater program security and avoids unintended data corruption.
- **Abstraction.** Objects only reveal internal mechanisms that are relevant for the use of other objects, hiding any unnecessary implementation code. The derived class can have its functionality extended. This concept can help developers more easily make additional changes or additions over time.
- **Inheritance.** Classes can reuse code from other classes. Relationships and subclasses between objects can be assigned, enabling developers to reuse common logic while still maintaining a unique hierarchy. This property of OOP forces a more thorough data analysis, reduces development time and ensures a higher level of accuracy.
- **Polymorphism.** Objects are designed to share behaviors and they can take on more than one form. The program will determine which meaning or usage is necessary for each execution of that object from a parent class, reducing the need to duplicate code. A child class is then created, which extends the functionality of the parent class. Polymorphism allows different types of objects to pass through the same interface.<br /><sub>Animal speak() -> With Cat "Meow" -> With Dog "Woof"</sub>

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