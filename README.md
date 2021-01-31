# **DesignPatternsSample**

# Creational Patterns


### Factory Pattern

Use Factory Pattern;

>When you are uncertain of the type and dependencies of the objects you will use.

>When the construction is very complex and you need to reuse it.


| Pros  |Cons   |
|---|---|
|Loose coupling between the  creator and the concrete products.|Makes code more difficult to read.|
|Single Responsibility.(only one class responsible the object creation)|Can be anti pattern when incorrectly used.|
|Open/Closed Principle.(you can add new types of object witout breaking the existing one)||
---------------
<br>

# Behavioral Patterns

## Observer Pattern

Use Observer Pattern;

>When the change of a state in one event affects other objects 

| Pros  |Cons   |
|---|---|
|Open/Closed Principle.(when you want additional observers you don't need to change the subject's code)|The order of notifying observers is random|

<br>

## Mediator Pattern

Use Mediator Pattern;

>When you want to reduce the relationship between a set of objects

>When the complexity of object interaction begins to hold up object reusability

>When changes in the state of one object affects many other objects.

| Pros  |Cons   |
|---|---|
|Low coupling.(a component only depends on the mediator. It makes a many-to-many interaction a one-to-many interaction.)|God object!(when over used)|
|Increases reusability.||
|Open/Closed Principle.(you can add more objects, that communicate with others, without any change.)||
|Single Responsibility.(removes the communication from objects into a single place)||

<br>

# Structural Patterns

## Decorator Pattern

Use Decorator Pattern;

>When you need to extra behaviors to objects in run time.(It allows you to divide business logic into layers)

>When it isn't possible to extend an object’s behavior using inheritance.(Final classes)

| Pros  |Cons   |
|---|---|
|Extendable object behavior without creating subclasses.|Code maintainability.(lots of small decorators)|
|Add/remove additional functionalities/responsibilities at run time.|It can be complicated to have decorators keep track of other decorators.|
|Combining multiple behaviours by wrapping.||
|Single Responsibility.(dividing behaviors)||