# DesignPatterns
https://refactoring.guru/design-patterns/catalog
## Builder
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
### Problem
Imagine a complex object that requires laborious, step-by-step initialization of many fields and nested objects. Such initialization code is usually buried inside a monstrous constructor with lots of parameters. Or even worse: scattered all over the client code.
For example, let�s think about how to create a `House` object. To build a simple house, you need to construct four walls and a floor, install a door, fit a pair of windows, and build a roof. But what if you want a bigger, brighter house, with a backyard and other goodies (like a heating system, plumbing, and electrical wiring)?
The simplest solution is to extend the base `House` class and create a set of subclasses to cover all combinations of the parameters. But eventually you�ll end up with a considerable number of subclasses. Any new parameter, such as the porch style, will require growing this hierarchy even more.
There�s another approach that doesn�t involve breeding subclasses. You can create a giant constructor right in the base `House` class with all possible parameters that control the house object. While this approach indeed eliminates the need for subclasses, it creates another problem.
### Solution
The Builder pattern suggests that you extract the object construction code out of its own class and move it to separate objects called builders.
The pattern organizes object construction into a set of steps (`buildWalls`, `buildDoor`, etc.). To create an object, you execute a series of these steps on a builder object. The important part is that you don�t need to call all of the steps. You can call only those steps that are necessary for producing a particular configuration of an object.
Some of the construction steps might require different implementation when you need to build various representations of the product. For example, walls of a cabin may be built of wood, but the castle walls must be built with stone.
In this case, you can create several different builder classes that implement the same set of building steps, but in a different manner. Then you can use these builders in the construction process (i.e., an ordered set of calls to the building steps) to produce different kinds of objects.