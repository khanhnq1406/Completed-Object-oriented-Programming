# Object-oriented Programming
## Table of contents
- [OOP](#oop)
- [Overloading and Access Modifiers](#overloading-and-access-modifiers)
- [Static](#static)
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

    
# Link
- [Object-oriented Programming (OOP)](https://www.techtarget.com/searchapparchitecture/definition/object-oriented-programming-OOP) <br />
- [C# Access Modifiers](https://www.w3schools.com/cs/cs_access_modifiers.php) <br />
- [Difference between Ref and Out keywords in C#](https://www.geeksforgeeks.org/difference-between-ref-and-out-keywords-in-c-sharp/) <br />
- [C# Method Overloading](https://www.programiz.com/csharp-programming/method-overloading) <br />
- [Static keyword in C#](https://www.geeksforgeeks.org/static-keyword-in-c-sharp/) <br />
