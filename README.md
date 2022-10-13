# Object-oriented Programming
- [Object-oriented Programming](#object-oriented-programming)
  - [OOP](#oop)
    - [Structure of object-oriented programming](#structure-of-object-oriented-programming)
    - [The main principles of OOP](#the-main-principles-of-oop)
    - [Qualitise of an Object-Oriented System](#qualitise-of-an-object-oriented-system)
  - [The Difference Between a Framework and a Library](#the-difference-between-a-framework-and-a-library)
  - [The difference between abstract class and interface](#the-difference-between-abstract-class-and-interface)
  - [The SOLID Principles of Object-Oriented Programming](#the-solid-principles-of-object-oriented-programming)
  - [CRC cards](#crc-cards)
  - [Unified Process](#unified-process)
    - [**Inception phase**](#inception-phase)
    - [**Elaboration phase**](#elaboration-phase)
    - [**Construction phase**](#construction-phase)
    - [**Transition phase**](#transition-phase)
- [Link](#link)
## OOP
### Structure of object-oriented programming
- **Classes** are user-defined data types that act as the blueprint for individual objects, attributes and methods. <sub>Vehicle</sub>
- **Objects** are instances of a class created with specifically defined data. Objects can correspond to real-world objects or an abstract entity. When class is defined initially, the description is the only object that is defined. <sub>car, motorcycle, bicycle</sub>
- **Methods** are functions that are defined inside a class that describe the behaviors of an object. Each method contained in class definitions starts with a reference to an instance object. Additionally, the subroutines contained in an object are called instance methods. Programmers use methods for reusability or keeping functionality encapsulated inside one object at a time. <sub>Drive(), Brake(), Refuel()</sub>
- **Attributes** are defined in the class template and represent the state of an object. Objects will have data stored in the attributes field. Class attributes belong to the class itself. <sub>weight, color</sub>

### The main principles of OOP
- **Encapsulation.** This principle states that **all important information is contained inside an object and only select information is exposed**. The implementation and state of each object are privately held inside a defined class. Other objects do not have access to this class or the authority to make changes. They are only able to call a list of public functions or methods. This characteristic of data hiding provides greater program security and avoids unintended data corruption. (private, public)
- **Abstraction.** Objects only reveal internal mechanisms that are relevant for the use of other objects, hiding any unnecessary implementation code. The derived class can have its functionality extended. This concept can help developers more easily make additional changes or additions over time.
- **Inheritance.** Inheritance is a feature or a process in which, new classes are created from the existing classes. The new class created is called “derived class” or “child class” and the existing class is known as the “base class” or “parent class”. **The derived class now is said to be inherited from the base class.** This property of OOP forces a more thorough data analysis, reduces development time and ensures a higher level of accuracy.
- **Polymorphism.** Objects are designed to share behaviors and **they can take on more than one form**. The program will determine which meaning or usage is necessary for each execution of that object from a parent class, reducing the need to duplicate code. A child class is then created, which extends the functionality of the parent class. Polymorphism allows different types of objects to pass through the same interface. (overriding and overloading)<br /><sub>Animal speak() -> With Cat "Meow" -> With Dog "Woof"</sub>

### Qualitise of an Object-Oriented System
- Reusability
- Reliability
- Robustness
- Extensibility
- Maintainability
## The Difference Between a Framework and a Library
https://www.freecodecamp.org/news/the-difference-between-a-framework-and-a-library-bd133054023f/
- Frameworks and libraries are both code written by someone else that helps you perform some common tasks in a less verbose way.
- A framework inverts the control of the program. It tells the developer what they need. A library doesn’t. The programmer calls the library where and when they need it.
- The degree of freedom a library or framework gives the developer will dictate how “opinionated” it is.

## The difference between abstract class and interface
https://www.javatpoint.com/difference-between-abstract-class-and-interface
| Abstract class                                                                   | Interface                                                     |
|----------------------------------------------------------------------------------|---------------------------------------------------------------|
| 1) Abstract class can have abstract and non-abstract methods.                    | Interface can have only abstract methods.                     |
| 2) Abstract class doesn't support multiple inheritance.                          | Interface supports multiple inheritance.                      |
| 3) Abstract class can have final, non-final, static and non-static variables.    | Interface has only static and final variables.                |
| 4) Abstract class can provide the implementation of interface.                   | Interface can't provide the implementation of abstract class. |
| 5) The abstract keyword is used to declare abstract class.                       | The interface keyword is used to declare interface.           |
| 6) An abstract class can extend another class and implement multiple interfaces. | An interface can extend another interface only.               |
| 7) An abstract class can have class members like private, protected, etc.        | Members of an interface are public by default.                |

## The SOLID Principles of Object-Oriented Programming
https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english/
<br />
Following the SOLID acronym:
- **The Single Responsibility Principle:** a class should **do one thing** and therefore it should have only a single reason to change.
- **The Open-Closed Principle:** classes should be **open for extension** and **closed to modification**. Modification means changing the code of an existing class, and extension means adding new functionality. 
- **The Liskov Substitution Principle:** subclasses should be substitutable for their base classes. This means that, given that class B is a subclass of class A, we should be able to pass an object of class B to any method that expects an object of class A and the method should not give any weird output in that case.
- **The Interface Segregation Principle:** Segregation means **keeping things separated**, and the Interface Segregation Principle is about separating the interfaces.
- **The Dependency Inversion Principle:** our classes should **depend upon interfaces or abstract classes** instead of concrete classes and functions.

## CRC cards
CRC cards, which characterize objects by class name, responsibilities, and collaborators.
- The **class name** of an object creates a vocabulary for discussing a design. 
- **Responsibilities** identify problems to be solved. 
- All objects stand in **relationship** to others, on whom they rely for services and control.

## Unified Process
https://en.wikipedia.org/wiki/Unified_Process <br />
<img src = 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/Unified_Process_Model_for_Iterative_Development.svg/400px-Unified_Process_Model_for_Iterative_Development.svg.png'></img> <br />
### **Inception phase**
Develop an approximate vision of the system, make the business case, define the <mark>scope</mark>, and produce a rough <mark>cost estimate</mark> and <mark>project schedule.</mark>
### **Elaboration phase**
During the Elaboration phase, the project team is expected to capture a healthy majority of the system requirements. However, the primary goals of Elaboration are to address known <mark>risk factors and to establish and validate the system architecture.</mark> Common processes undertaken in this phase include the creation of use case diagrams, conceptual diagrams (class diagrams with only basic notation) and package diagrams (architectural diagrams). <br />
The architecture is validated primarily through the implementation of an Executable Architecture Baseline. This is a partial implementation of the system which includes the core most architecturally significant components. It is built in a series of small time-boxed iterations. By the end of the Elaboration phase, the system architecture must have stabilized and the executable architecture baseline must demonstrate that the architecture will support the key system functionality and exhibit the right behavior in terms of performance, scalability, and cost.<br />
The final Elaboration phase deliverable is a plan (including cost and schedule estimates) for the Construction phase. At this point the plan should be accurate and credible since it should be based on the Elaboration phase experience and since significant risk factors should have been addressed during the Elaboration phase.
### **Construction phase**
Construction is the largest phase of the project. In this phase, <mark>the remainder of the system is built on the foundation laid in Elaboration.</mark> System features are implemented in a series of short, time-boxed iterations. Each iteration results in an executable release of the software. It is customary to write full-text use cases during the construction phase and each one becomes the start of a new iteration. Common Unified Modeling Language (UML) diagrams used during this phase include activity diagrams, sequence diagrams, collaboration diagrams, State Transition diagrams and interaction overview diagrams. Iterative implementation for the lower risks and easier elements are done. The final Construction phase deliverable is software ready to be deployed in the Transition phase.
### **Transition phase**
The final project phase is Transition. In this phase <mark>the system is deployed to the target users.</mark> Feedback received from an initial release (or initial releases) may result in further refinements to be incorporated over the course of several Transition phase iterations. The Transition phase also includes system conversions and user training.

# Link
- [Object-oriented Programming (OOP)](https://www.techtarget.com/searchapparchitecture/definition/object-oriented-programming-OOP) 
- [The Difference Between a Framework and a Library](https://www.freecodecamp.org/news/the-difference-between-a-framework-and-a-library-bd133054023f/)
- [Difference between abstract class and interface](https://www.javatpoint.com/difference-between-abstract-class-and-interface)
- [The SOLID Principles of Object-Oriented Programming Explained in Plain English](https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english/)
- [Unified Process](https://en.wikipedia.org/wiki/Unified_Process)