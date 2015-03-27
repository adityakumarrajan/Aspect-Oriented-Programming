Aspect oriented programming, or “AOP”, is the programming style 
which allows the separation of distinct, independent functions. 
Seperating cross cutting concers out of the main application and having it as components with single responsibility,
Thus making modular components.

Benifits of AOP...
a) Code will be cleaner
b) Less Code Repetation.
c) Code abstraction and modularity increases
d) Improves maintenance for performance tracking and debugging
e) less defects
f) More resilient code when adding and removing functionality
g) Increases team productivity due to organized readability

Whats Required to Achive AOP:
a) Create a Wrapper
b) Follow Single Responsibility Principle.
c) Decorator Pattern
d) Open Closed Principle.

Examples of a few cross cutting concers that we can implement using AOP are:
Data Binding (INotifyPropertyChanged)
Data Validation
Thread synchronization (locking)
Authorization
Transaction management (transaction commit rollback)
Exception handling
Sanity checks 
Cache Techniques
Persistent objects (whether to database, XML config file, registry, app.config, …)


We can create and attach Aspects in 2 ways:
a) Creating Interceptors
   In this technique we use, framework like POSTSHARP and create Interceptors.

b) Using Code Weaving Technique
run after your application compilation.
Post Prossing Technique where aspects are applied on top of your dlls.

Where we can attach our aspects.
For any given method that is getting executed, there are 4 scenerios where we can attach our Aspects.
a) ON START
b) ON SUCESS (Code that do not throw an exception)
c) ON EXIT
d) ON ERROR

    
Using Interceptors:
